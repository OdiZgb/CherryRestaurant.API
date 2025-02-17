
using AutoMapper;
using Data;
using MediatR;
public class AddPayLaterommandHandeler : IRequestHandler<AddPayLaterCommand, PayLaterDTO>
{
    public AppDbContext _dbContext { set; get; }
    private readonly IMapper _mapper;
    public AddPayLaterommandHandeler(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<PayLaterDTO> Handle(AddPayLaterCommand request, CancellationToken cancellationToken)
    {
        var payLater = _mapper.Map<PayLater>(request._payLater);

        var payLaterDB = _dbContext.PayLaters.Add(payLater);
        await _dbContext.SaveChangesAsync(cancellationToken);
 
        return _mapper.Map<PayLaterDTO>(payLater);
    }
}
