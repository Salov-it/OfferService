using FluentValidation;


namespace OfferService.Application.CQRS.Querries.GetByOwnerIdQuerry
{
    internal class GetByOwnerIdValidator : AbstractValidator<GetByOwnerIdQuerry>
    {
        public void GetByOwnerValidator()
        {
            RuleFor(opt => opt.ownerId).NotEmpty();
            RuleFor(opt => opt.ownerId).GreaterThan(0);
        }
    }
}
