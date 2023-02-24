using MediatR;
using Microsoft.EntityFrameworkCore;
using OfferService.Application.Interface;
using OfferService.Domain;

namespace OfferService.Application.CQRS.Querries.GetByIdQuerry
{
    public class GetByIdHandler : IRequestHandler<GetByIdQuerry, Offer>
    {
        private readonly IOfferContext _OfferContext;
        public GetByIdHandler(IOfferContext BanContext)
        {
            _OfferContext = BanContext;
        }
        public async Task<Offer> Handle(GetByIdQuerry request, CancellationToken cancellationToken)
        {
            return await _OfferContext.offers.FirstOrDefaultAsync(w => w.id == request.Id, cancellationToken);
        }
    }
}
