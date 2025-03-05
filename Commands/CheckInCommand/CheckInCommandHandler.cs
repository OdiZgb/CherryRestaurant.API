using AutoMapper;
using Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class CheckInCommandHandler : IRequestHandler<CheckInCommand, EmployeeAttendanceDTO>
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public CheckInCommandHandler(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<EmployeeAttendanceDTO> Handle(CheckInCommand request, CancellationToken cancellationToken)
    {
          var existingOpen = await _dbContext.EmployeeAttendances
            .AnyAsync(a => a.EmployeeId == request.EmployeeId && a.CheckOutTime == null);

        if (existingOpen)
        {
            var lastCheckIn = await _dbContext.EmployeeAttendances
                .Where(a => a.EmployeeId == request.EmployeeId)
                .OrderByDescending(a => a.CheckInTime)
                .FirstOrDefaultAsync();

            throw new InvalidOperationException(
                $"Employee has an open check-in from {lastCheckIn?.CheckInTime:yyyy-MM-dd HH:mm}. " +
                "Please check out first.");
        }
 
        var attendance = new EmployeeAttendance
        {
            EmployeeId = request.EmployeeId,
            CheckInTime = DateTime.UtcNow
        };

        _dbContext.EmployeeAttendances.Add(attendance);
        await _dbContext.SaveChangesAsync();

        return _mapper.Map<EmployeeAttendanceDTO>(attendance);
    }
}