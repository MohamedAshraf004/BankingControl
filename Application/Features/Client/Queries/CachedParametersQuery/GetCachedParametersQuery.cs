﻿using MediatR;

namespace Application.Features.Client.Queries.CachedParametersQuery
{
    public class GetCachedParametersQuery : IRequest<IEnumerable<GetCachedParametersQueryResponse>>
    {
    }
}