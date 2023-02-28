using OfferService.Domain;
using MediatR;

namespace OfferService.Application.CQRS.Command.Create
{
    public class CreateOfferСommand : IRequest<Offer>
    {
        public int ownerId { get; set; }
        public int minCount { get; set; }
        public int count { get; set; }
        public decimal price { get; set; }
    }
}
