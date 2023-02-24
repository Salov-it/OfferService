using MediatR;
using Microsoft.EntityFrameworkCore;
using OfferService.Application.Interface;
using OfferService.Domain;

namespace OfferService.Application.CQRS.Querries.GetByOwnerIdQuerry
{
    internal class GetByOwnerIdHandler : IRequestHandler<GetByOwnerIdQuerry, Offer>
    {
        private readonly IOfferContext _context;
        public GetByOwnerIdHandler(IOfferContext context)
        {
            _context = context;
        }
        public async Task<Offer> Handle(GetByOwnerIdQuerry request, CancellationToken cancellationToken)
        {
            var offers = await _context.offers.FirstOrDefaultAsync(w => w.ownerId == request.ownerId);
            if (offers == null)
            {
                return null;
            }
            return offers;
        }
    }
}
