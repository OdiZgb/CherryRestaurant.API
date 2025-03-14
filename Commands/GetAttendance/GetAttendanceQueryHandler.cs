using AutoMapper;
using Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetAttendanceQueryHandler : IRequestHandler<GetAttendanceQuery, IEnumerable<EmployeeAttendanceDTO>>
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetAttendanceQueryHandler(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<IEnumerable<EmployeeAttendanceDTO>> Handle(GetAttendanceQuery request, CancellationToken cancellationToken)
    {
        var query = _dbContext.EmployeeAttendances.AsQueryable();

        if (request.EmployeeId.HasValue)
            query = query.Where(a => a.EmployeeId == request.EmployeeId.Value);

        if (request.StartDate.HasValue)
            query = query.Where(a => a.CheckInTime >= request.StartDate.Value);

        if (request.EndDate.HasValue)
            query = query.Where(a => a.CheckInTime < request.EndDate.Value.AddDays(1));

        var attendances = await query.ToListAsync();
        var at = _mapper.Map<IEnumerable<EmployeeAttendanceDTO>>(attendances).OrderByDescending(x=>x.CheckInTime);
        return at;
    }
}