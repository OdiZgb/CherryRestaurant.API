using MediatR;


  public class AddPayLaterCommand : IRequest<PayLaterDTO>
  {
    public PayLaterDTO _payLater;
    public AddPayLaterCommand(PayLaterDTO payLater)
    {
      _payLater = payLater;
    }
  }
