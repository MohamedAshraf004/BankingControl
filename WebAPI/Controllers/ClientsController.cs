using Application.Client.Commands.Create;
using Application.Client.Queries.GetClients;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly ILogger<ClientsController> _logger;
        private readonly IMediator _mediator;

        public ClientsController(ILogger<ClientsController> logger,IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet(Name = "GetClients")]
        public async Task<GetClientsQueryResponse> Get([FromQuery]GetClientsQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost(Name = "AddClient")]
        public async Task<CreateClientCommandResponse> Create([FromBody] CreateClientCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
