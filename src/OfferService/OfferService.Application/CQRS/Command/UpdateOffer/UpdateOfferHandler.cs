using OfferService.Domain;
using OfferService.Application.Interface;
using MediatR;

namespace OfferService.Application.CQRS.Command.UpdateOffer
{
    public class UpdateOfferHandler : IRequestHandler<UpdateOfferCommand, Offer>
    {
        private readonly IOfferContext _context;
        public UpdateOfferHandler(IOfferContext context)
        {
            _context = context;
        }

        public async Task<Offer> Handle(UpdateOfferCommand request, CancellationToken cancellationToken)
        {
            var content = _context.offers.Find(request.id);

            if (content == null)
            {
                // Exception
                return null;
            }

            content.minCount = request.minCount;
            content.count = request.count;
            content.price = request.price;
            content.updatedAt = DateTime.Now.ToString();

            await _context.SaveChangesAsync(cancellationToken);
            return content;

        }
    }
}
