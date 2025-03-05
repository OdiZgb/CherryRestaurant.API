using Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetAttendanceSummaryQueryHandler : IRequestHandler<GetAttendanceSummaryQuery, AttendanceSummaryDTO>
{
    private readonly AppDbContext _dbContext;

    public GetAttendanceSummaryQueryHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<AttendanceSummaryDTO> Handle(GetAttendanceSummaryQuery request, CancellationToken cancellationToken)
    {
        var asOfDate = request.AsOfDate ?? DateTime.UtcNow.Date;

        var todayAttendances = await GetAttendances(request.EmployeeId, asOfDate.Date, asOfDate.AddDays(1));
        var monthAttendances = await GetAttendances(request.EmployeeId, new DateTime(asOfDate.Year, asOfDate.Month, 1), new DateTime(asOfDate.Year, asOfDate.Month, 1).AddMonths(1));
        var yearAttendances = await GetAttendances(request.EmployeeId, new DateTime(asOfDate.Year, 1, 1), new DateTime(asOfDate.Year + 1, 1, 1));

        return new AttendanceSummaryDTO
        {
            EmployeeId = request.EmployeeId,
            TotalHoursToday = CalculateTotalHours(todayAttendances),
            TotalHoursThisMonth = CalculateTotalHours(monthAttendances),
            TotalHoursThisYear = CalculateTotalHours(yearAttendances)
        };
    }

    private async Task<List<EmployeeAttendance>> GetAttendances(int employeeId, DateTime start, DateTime end)
    {
        return await _dbContext.EmployeeAttendances
            .Where(a => a.EmployeeId == employeeId &&
                        a.CheckInTime >= start &&
                        a.CheckInTime < end &&
                        a.CheckOutTime != null)
            .ToListAsync();
    }

    private TimeSpan CalculateTotalHours(List<EmployeeAttendance> attendances)
    {
        var totalHours = attendances.Sum(a => (a.CheckOutTime - a.CheckInTime)?.TotalHours ?? 0);
        return TimeSpan.FromHours(totalHours);
    }
}