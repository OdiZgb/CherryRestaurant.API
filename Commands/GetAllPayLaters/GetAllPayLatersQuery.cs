using MediatR;


  public class GetAllPayLatersQuery : IRequest<IEnumerable<PayLaterDTO>>
  {
    public GetAllPayLatersQuery()
    {
    }
  }
