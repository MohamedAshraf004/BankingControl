using Application.Contracts.Caching;
using Application.Features.Client.Queries.GetClients;
using AutoMapper;
using Domain.Common.Consts;
using MediatR;

namespace Application.Features.Client.Queries.CachedParametersQuery
{
    public class GetCachedParametersQueryHandler(ICachingService<GetClientsQuery> cache,IMapper mapper) : IRequestHandler<GetCachedParametersQuery, IEnumerable<GetCachedParametersQueryResponse>>
    {
        public async Task<IEnumerable<GetCachedParametersQueryResponse>> Handle(GetCachedParametersQuery request, CancellationToken cancellationToken)
        {
            if (cache.IsCached(ConstsValue.CachedKey))
            {
                var cachedParameters = cache.GetCacheKey(ConstsValue.CachedKey);
                return cachedParameters.Select(mapper.Map<GetCachedParametersQueryResponse>).TakeLast(3);
            }

            return await Task.FromResult<IEnumerable<GetCachedParametersQueryResponse>>(null);
        }
    }
}