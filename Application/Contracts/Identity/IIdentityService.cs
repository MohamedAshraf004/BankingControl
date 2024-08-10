using Application.Features.User.Command.Register;
using Application.Responses;

namespace Application.Contracts.Identity
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(RegisterUserCommand request);

        Task<AuthenticationResult> LoginAsync(string email, string password);

    }
}