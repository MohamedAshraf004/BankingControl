using Domain.Common.Consts;
using FluentValidation;

namespace Application.Client.Commands.Create
{
    public class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidator(IValidator<AccountInput> accountValidator,IValidator<AddressInput> addressValidator)
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .MaximumLength(59);

            
            RuleFor(x => x.LastName)
                .NotEmpty()
                .MaximumLength(59);
            
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.MobileNumber)
                .Matches(ConstsValue.Mobile_REGEX);

            RuleFor(x=>x.Gender)
                .NotEmpty()
                .IsInEnum();
            RuleFor(x => x.Address)
                .NotEmpty()
                .SetValidator(addressValidator);
            RuleFor(x => x.Accounts)
                .NotEmpty()
                .Must(x => x.Count > 0)
                .DependentRules(() =>
                {
                    RuleForEach(x => x.Accounts)
                    .SetValidator(accountValidator);
                });
        }
    }
}