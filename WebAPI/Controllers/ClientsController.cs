using Application.Client.Commands.Create;
using Application.Client.Queries.GetClients;
using Application.Features.Client.Queries.CachedParametersQuery;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly ILogger<ClientsController> _logger;
        private readonly IMediator _mediator;

        public ClientsController(ILogger<ClientsController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [Authorize]
        [HttpGet(Name = "GetClients")]
        public async Task<GetClientsQueryResponse> Get([FromQuery] GetClientsQuery query)
        {
            return await _mediator.Send(query);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost(Name = "AddClient")]
        public async Task<CreateClientCommandResponse> Create([FromBody] CreateClientCommand command)
        {
            return await _mediator.Send(command);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("[action]", Name = "GetCachedParameters")]
        public async Task<IEnumerable<GetCachedParametersQueryResponse>> CachedParameters()
        {

            return await _mediator.Send(new GetCachedParametersQuery());
        }
    }
}