using FluentValidation;

namespace Application.Features.User.Command.Login
{
    public class LoginCommandHandlerValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandHandlerValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty();
        }
    }
}