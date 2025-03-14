using Commands.deleteItem;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("bill")]
  [ApiController]
  public class BillController : ControllerBase
  {
    private readonly IMediator _mediator;
    public BillController(IMediator mediator)
    {
      _mediator = mediator;
    }

    [HttpPost("addToBill")]
    public async Task<ActionResult<BillDTO>> addToBill([FromBody] BillDTO billDTO)
    {
      var command = new AddToBillCommand(billDTO);
      var BillDTO = await _mediator.Send(command);
      return Ok(BillDTO);
    }
    
    [HttpPost("addRefundToBill")]
    public async Task<ActionResult<BillDTO>> addRefundToBill([FromBody] BillDTO billDTO)
    {
      var command = new addRefundToBillCommand(billDTO);
      var BillDTO = await _mediator.Send(command);
      return Ok(BillDTO);
    }


    [HttpPut("completeDebt/{id}")]
    public async Task<ActionResult<ClientDebtDTO>> completeDebt(int id)
    {
      var command = new CompleteDebtCommand(id);
      var ClientDebtDTO = await _mediator.Send(command);
      return Ok(ClientDebtDTO);
    }


    
  [HttpGet("getAllBills")]
  public async Task<ActionResult<IEnumerable<BillDTO>>> getAllBill()
  {
    var query = new GetAllBillsQuery();
    var AllBill = await _mediator.Send(query);
    return Ok(AllBill);
  }

  [HttpGet("getAllClientDebts")]
  public async Task<ActionResult<IEnumerable<ClientDebtDTO>>> getAllClientDebts()
  {
    var query = new GetAllClientDebtsQuery();
    var AllDebts = await _mediator.Send(query);
    return Ok(AllDebts);
  }

  [HttpDelete("DeleteCashBill/{id}")]
  public async Task<ActionResult<bool>> DeleteCashBill(int id)
  {
    var command = new DeleteCashBillCommand(id);
    var DeleteCashBill = await _mediator.Send(command);
    return Ok("deleted.");
  }
  }