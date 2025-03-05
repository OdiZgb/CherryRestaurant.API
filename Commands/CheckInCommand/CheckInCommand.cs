using MediatR;

public record CheckInCommand(int EmployeeId) : IRequest<EmployeeAttendanceDTO>;