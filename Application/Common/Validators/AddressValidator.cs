using Application.Client.Commands.Create;
using Domain.Common.Consts;
using FluentValidation;

namespace Application.Common.Validators
{
    public class AddressValidator : AbstractValidator<AddressInput>
    {
        public AddressValidator()
        {
            RuleFor(x => x.PostalCode)
                .NotEmpty()
                .Matches(ConstsValue.DigitsOnly_REGEX);
            RuleFor(x => x.Country)
                   .NotEmpty();
            RuleFor(x => x.Country)
                     .NotEmpty();
            RuleFor(x => x.Country)
                   .NotEmpty();
        }
    }
}