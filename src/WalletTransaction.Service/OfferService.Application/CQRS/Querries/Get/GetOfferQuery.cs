using MediatR;
using OfferService.Domain;

namespace OfferService.Application.CQRS.Querries.Get
{
    public class GetOfferQuery : IRequest<List<Offer>>
    {

    }
}
