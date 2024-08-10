using Application.Responses;
using MediatR;

namespace Application.Features.User.Command.Login
{
    public class LoginCommand : IRequest<AuthenticationResult>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}