using Application.Contracts.Identity;
using Application.Responses;
using MediatR;

namespace Application.Features.User.Command.Login
{
    public class LoginCommandHandler(IIdentityService identityService) : IRequestHandler<LoginCommand, AuthenticationResult>
    {
        private readonly IIdentityService _identityService = identityService;

        public async Task<AuthenticationResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            return await _identityService.LoginAsync(request.Email, request.Password);
        }
    }
}