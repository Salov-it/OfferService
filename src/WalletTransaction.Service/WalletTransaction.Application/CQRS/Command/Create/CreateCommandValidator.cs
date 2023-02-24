using FluentValidation;

namespace OfferService.Application.CQRS.Command.Create
{
    public class CreateCommandValidator : AbstractValidator<CreateOfferСommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(query => query.ownerId).GreaterThan(0);
            RuleFor(query => query.id).GreaterThan(0);
        }
    }
}
