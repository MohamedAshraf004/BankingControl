using Application.Client.Queries.GetClients;
using Application.Common.Helpers;
using Application.Contracts.Persistence;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ClientRepository(AppDbContext dbContext, IMapper mapper) : BaseRepository<Client>(dbContext), IClientRepository
    {
        public async Task<PaginatedList<ClientDto>> GetAll(GetClientsQuery query)
        {
            var clients = _dbContext.Clients
                .Include(x=>x.Accounts)
                .AsNoTracking();
            if (query.Gender is not null)
                clients.Where(x => x.Gender == query.Gender.Value);

            if (!string.IsNullOrWhiteSpace(query.ClientName))
                clients.Where(x => x.FirstName.Contains(query.ClientName, StringComparison.OrdinalIgnoreCase)
                || x.LastName.Contains(query.ClientName, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(query.Email))
                clients.Where(x => x.Email.Equals(query.Email, StringComparison.OrdinalIgnoreCase));

            if (query.OrderByDesc)
                clients.OrderByDescending(x => x.Id);

            var clientsDto = await clients.ProjectTo<ClientDto>(mapper.ConfigurationProvider).ToListAsync();
            //var clientsDto = clients.Select(mapper.Map<ClientDto>).ToList();
            return PaginatedList<ClientDto>.Create(clientsDto, query.PageIndex, query.PageSize);
        }
    }
}