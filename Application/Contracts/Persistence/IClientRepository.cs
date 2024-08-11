using Application.Common.Helpers;
using Application.Features.Client.Queries.GetClients;

namespace Application.Contracts.Persistence
{
    public interface IClientRepository : IAsyncRepository<Domain.Entities.Client>
    {
        Task<PaginatedList<ClientDto>> GetAll(GetClientsQuery query);
    }
}