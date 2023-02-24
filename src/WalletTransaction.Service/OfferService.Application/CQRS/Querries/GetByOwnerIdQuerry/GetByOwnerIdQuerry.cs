using MediatR;
using OfferService.Domain;

namespace OfferService.Application.CQRS.Querries.GetByOwnerIdQuerry
{
    public class GetByOwnerIdQuerry : IRequest<Offer>
    {
        public int ownerId { get; set; }
    }
}
