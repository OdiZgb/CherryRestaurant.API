using AutoMapper;
using Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class CheckOutCommandHandler : IRequestHandler<CheckOutCommand, EmployeeAttendanceDTO>
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public CheckOutCommandHandler(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<EmployeeAttendanceDTO> Handle(CheckOutCommand request, CancellationToken cancellationToken)
    {
        var attendance = await _dbContext.EmployeeAttendances
            .Where(a => a.EmployeeId == request.EmployeeId && a.CheckOutTime == null)
            .OrderByDescending(a => a.CheckInTime)
            .FirstOrDefaultAsync();

        if (attendance == null)
            throw new InvalidOperationException("No open check-in found for this employee.");

        attendance.CheckOutTime = DateTime.Now;
        await _dbContext.SaveChangesAsync();

        return _mapper.Map<EmployeeAttendanceDTO>(attendance);
    }
}