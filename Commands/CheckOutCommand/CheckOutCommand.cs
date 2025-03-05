using MediatR;

public record CheckOutCommand(int EmployeeId) : IRequest<EmployeeAttendanceDTO>;