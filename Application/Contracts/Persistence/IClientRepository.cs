using Application.Client.Queries.GetClients;
using Application.Common.Helpers;

namespace Application.Contracts.Persistence
{
    public interface IClientRepository : IAsyncRepository<Domain.Entities.Client>
    {
        Task<PaginatedList<ClientDto>> GetAll(GetClientsQuery query);
    }
}