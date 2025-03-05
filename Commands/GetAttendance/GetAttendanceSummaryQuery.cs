using MediatR;

public class GetAttendanceSummaryQuery : IRequest<AttendanceSummaryDTO>
{
    public int EmployeeId { get; set; }
    public DateTime? AsOfDate { get; set; }
}