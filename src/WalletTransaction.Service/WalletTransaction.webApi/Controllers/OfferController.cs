using MediatR;
using Microsoft.AspNetCore.Mvc;
using OfferService.Application.CQRS.Command.Create;
using OfferService.Application.CQRS.Querries.GetByOwnerIdQuerry;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OfferService.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IMediator mediator;

        public OfferController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] int ownerId, int minCount, int count, decimal price)
        {
            var content = new CreateOfferСommand
            {
                id = 6,
                ownerId = 4,
                minCount = minCount,
                count = count,
                price = price
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        [HttpGet]
        public async Task<IActionResult> GetByEntity(int ownerId)
        {
            var content = new GetByOwnerIdQuerry
            {
                ownerId = ownerId
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }
    }
} 
