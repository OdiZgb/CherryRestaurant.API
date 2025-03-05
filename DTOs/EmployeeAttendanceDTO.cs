using System;

public class EmployeeAttendanceDTO
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public DateTime CheckInTime { get; set; }
    public DateTime? CheckOutTime { get; set; }
    public TimeSpan? Duration => CheckOutTime - CheckInTime;
}

public class AttendanceSummaryDTO
{
    public int EmployeeId { get; set; }
    public TimeSpan TotalHoursToday { get; set; }
    public TimeSpan TotalHoursThisMonth { get; set; }
    public TimeSpan TotalHoursThisYear { get; set; }
}