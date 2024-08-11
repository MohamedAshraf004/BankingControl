using Application.Features.Client.Commands.Create;
using Domain.Common.Consts;
using FluentValidation;

namespace Application.Common.Validators
{
    public class AccountValidator : AbstractValidator<AccountInput>
    {
        public AccountValidator()
        {
            RuleFor(x => x.AccountType)
                .NotEmpty()
                .IsInEnum();

            RuleFor(x => x.IPAN)
                .NotEmpty()
                .Matches(ConstsValue.IBAN_REGEX); //NL39INGB0044332211
        }
    }
}