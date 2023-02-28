using MediatR;
using OfferService.Domain;
using OfferService.Application.Interface;
using System;

namespace OfferService.Application.CQRS.Command.Create
{
    public class CreateOfferCommandHandler : IRequestHandler<CreateOfferСommand, Offer>
    {
        private readonly IOfferContext _offerContext;
        public CreateOfferCommandHandler(IOfferContext context)
        {
            _offerContext = context;
        }

        public async Task<Offer> Handle(CreateOfferСommand request, CancellationToken cancellationToken)
        {
            var content = new Offer
            {
                ownerId = request.ownerId,
                minCount = request.minCount,
                count = request.count,
                price = request.price,
                createdAt = DateTime.Now.ToString(),
                updatedAt = DateTime.Now.ToString(),
            };

            await _offerContext.offers.AddAsync(content);
            await _offerContext.SaveChangesAsync(cancellationToken);

            return content;
        }
    }
}
