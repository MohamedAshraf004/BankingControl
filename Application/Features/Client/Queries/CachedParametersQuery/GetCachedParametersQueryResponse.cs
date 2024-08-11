using Domain.Enums;

namespace Application.Features.Client.Queries.CachedParametersQuery
{
    public class GetCachedParametersQueryResponse
    {
        public string ClientName { get; set; }

        public string Email { get; set; }

        public Gender? Gender { get; set; }

        public bool OrderByDesc { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}