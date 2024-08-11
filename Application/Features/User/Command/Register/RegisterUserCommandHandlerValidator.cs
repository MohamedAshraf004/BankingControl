using FluentValidation;

namespace Application.Features.User.Command.Register
{
    public class RegisterUserCommandHandlerValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandHandlerValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Role)
                .NotEmpty()
                .IsInEnum();
            RuleFor(x => x.Password)
                .NotEmpty();

            RuleFor(x => x.PasswordConfirmation)
                .NotEmpty()
                .Equal(x => x.Password);
        }
    }
}