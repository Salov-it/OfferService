using MediatR;
using OfferService.Domain;

namespace OfferService.Application.CQRS.Querries.GetByIdQuerry
{
    public class GetByIdQuerry : IRequest<Offer>
    {
        public int Id { get; set; }
    }
}
