using Application.Contracts.Caching;
using Application.Contracts.Persistence;
using Domain.Common.Consts;
using MediatR;

namespace Application.Client.Queries.GetClients
{
    public class GetClientsQueryHandler(IClientRepository clientRepository,ICachingService<GetClientsQuery> cachingService) : IRequestHandler<GetClientsQuery, GetClientsQueryResponse>
    {

        public async Task<GetClientsQueryResponse> Handle(GetClientsQuery query, CancellationToken cancellationToken)
        {
            if (cachingService.IsCached(ConstsValue.CachedKey))
                cachingService.AddToKey(ConstsValue.CachedKey, query);
            else
                cachingService.Set(ConstsValue.CachedKey, query);

            var @clients = await clientRepository.GetAll(query);

            return new(clients);
        }
    }
}