
using AutoMapper;
using Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetAllPayLatersQueryHandeler : IRequestHandler<GetAllPayLatersQuery, IEnumerable<PayLaterDTO>>
{
  private IMapper _mapper;
  public AppDbContext _dbContext { set; get; }

  public GetAllPayLatersQueryHandeler(AppDbContext dbContext, IMapper mapper)
  {
    _mapper = mapper;
    _dbContext = dbContext;
  }

    public async Task<IEnumerable<PayLaterDTO>> Handle(GetAllPayLatersQuery request, CancellationToken cancellationToken)
    {

        List<PayLater> payLaters = await _dbContext.PayLaters.ToListAsync();
        return _mapper.Map<List<PayLaterDTO>>(payLaters);
    }
}