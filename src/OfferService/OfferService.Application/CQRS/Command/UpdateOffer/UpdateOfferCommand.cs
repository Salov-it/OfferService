using OfferService.Domain;
using MediatR;

namespace OfferService.Application.CQRS.Command.UpdateOffer
{
    public class UpdateOfferCommand : IRequest<Offer>
    {
        public int id { get; set; }
        public int minCount { get; set; }
        public int count { get; set; }
        public decimal price { get; set; }
    }
}
