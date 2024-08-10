using Application.Contracts.Identity;
using Application.Responses;
using MediatR;

namespace Application.Features.User.Command.Register
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, AuthenticationResult>
    {
        private readonly IIdentityService _identityService;

        public RegisterUserCommandHandler(IIdentityService identityService)
        {
            this._identityService = identityService;
        }

        public async Task<AuthenticationResult> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            return await _identityService.RegisterAsync(request);
        }
    }
}