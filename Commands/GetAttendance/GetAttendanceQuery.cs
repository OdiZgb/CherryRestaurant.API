using MediatR;

public class GetAttendanceQuery : IRequest<IEnumerable<EmployeeAttendanceDTO>>
{
    public int? EmployeeId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}