using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Client.Commands.Create
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, CreateClientCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;

        public CreateClientCommandHandler(IMapper mapper, IClientRepository clientRepository)
        {
            _mapper = mapper;
            this._clientRepository = clientRepository;
        }

        public async Task<CreateClientCommandResponse> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var @client = _mapper.Map<CreateClientCommand, Domain.Entities.Client>(request);
            await _clientRepository.AddAsync(@client);
            return new(client.Id);
        }
    }
}