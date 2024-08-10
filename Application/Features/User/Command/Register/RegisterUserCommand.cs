using Application.Responses;
using MediatR;

namespace Application.Features.User.Command.Register
{
    public class RegisterUserCommand : IRequest<AuthenticationResult>
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordConfirmation { get; set; }
        public UserRole Role { get; set; }
    }
}
