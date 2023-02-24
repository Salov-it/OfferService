using MediatR;
using OfferService.Application.Interface;
using OfferService.Domain;

namespace OfferService.Application.CQRS.Querries.Get
{
    public class GetOfferHandler : IRequestHandler<GetOfferQuery, List<Offer>>
    {
        private readonly IOfferContext _context;
        public GetOfferHandler(IOfferContext context)
        {
            _context = context;
        }

        public async Task<List<Offer>> Handle(GetOfferQuery request, CancellationToken cancellationToken)
        {

            return _context.offers.ToList();
        }
    }
}
