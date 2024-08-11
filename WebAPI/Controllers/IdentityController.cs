using Application.Features.User.Command.Login;
using Application.Features.User.Command.Register;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class IdentityController : ControllerBase
    {
        private readonly ILogger<IdentityController> _logger;
        private readonly IMediator _mediator;

        public IdentityController(ILogger<IdentityController> logger,
                                  IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost(Name = "Register")]
        public async Task<AuthenticationResult> Register([FromBody] RegisterUserCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPost(Name = "Login")]
        public async Task<AuthenticationResult> Login([FromBody] LoginCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}