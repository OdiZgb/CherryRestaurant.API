using Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/attendance")]
[ApiController]
public class EmployeeAttendanceController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly AppDbContext _dbContext;
    
    public EmployeeAttendanceController(IMediator mediator,AppDbContext dbContext)
    {
        _mediator = mediator;
        _dbContext = dbContext;

    }

    [HttpPost("checkin")]
    public async Task<ActionResult<EmployeeAttendanceDTO>> CheckIn([FromBody] CheckInCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPost("checkout")]
    public async Task<ActionResult<EmployeeAttendanceDTO>> CheckOut([FromBody] CheckOutCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<EmployeeAttendanceDTO>>> GetAttendance(
        [FromQuery] int? employeeId,
        [FromQuery] DateTime? startDate,
        [FromQuery] DateTime? endDate)
    {
        var query = new GetAttendanceQuery { EmployeeId = employeeId, StartDate = startDate, EndDate = endDate };
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpGet("summary")]
    public async Task<ActionResult<AttendanceSummaryDTO>> GetSummary(
        [FromQuery] int employeeId,
        [FromQuery] DateTime? asOfDate)
    {
        var query = new GetAttendanceSummaryQuery { EmployeeId = employeeId, AsOfDate = asOfDate };
        var result = await _mediator.Send(query);
        return Ok(result);
    }
[HttpGet("status/{employeeId}")]
public async Task<ActionResult<CheckInStatusDTO>> GetCheckInStatus(int employeeId)
{
    var lastCheckIn = await this._dbContext.EmployeeAttendances
        .Where(a => a.EmployeeId == employeeId)
        .OrderByDescending(a => a.CheckInTime)
        .FirstOrDefaultAsync();
        bool IsCheckedIn = false;
    
    if(lastCheckIn?.CheckOutTime == null){
        IsCheckedIn = true;

    }
    if(lastCheckIn== null){
        IsCheckedIn = false;
    }
    return new CheckInStatusDTO
    {
        IsCheckedIn =IsCheckedIn ,
        LastCheckInTime = lastCheckIn?.CheckInTime
    };
}

public class CheckInStatusDTO
{
    public bool IsCheckedIn { get; set; }
    public DateTime? LastCheckInTime { get; set; }
}
}