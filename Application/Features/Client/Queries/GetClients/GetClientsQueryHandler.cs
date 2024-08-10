using Application.Contracts.Persistence;
using MediatR;

namespace Application.Client.Queries.GetClients
{
    public class GetClientsQueryHandler(IClientRepository clientRepository) : IRequestHandler<GetClientsQuery, GetClientsQueryResponse>
    {
        public async Task<GetClientsQueryResponse> Handle(GetClientsQuery query, CancellationToken cancellationToken)
        {
            var @clients = await clientRepository.GetAll(query);

            return new(clients);
        }
    }
}