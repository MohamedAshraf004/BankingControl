﻿using Application.Client.Queries.GetClients;
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
            .Include(x => x.Accounts).AsNoTracking()
            .ProjectTo<ClientDto>(mapper.ConfigurationProvider)
            .Where(x =>
                (query.Gender != null && x.Gender == query.Gender) ||
                (!string.IsNullOrWhiteSpace(query.ClientName) && (x.FirstName.Contains(query.ClientName)
                    || x.LastName.Contains(query.ClientName)))
                || (!string.IsNullOrWhiteSpace(query.Email) && x.Email.Equals(query.Email))
            );
            if (query.OrderByDesc)
                clients.OrderByDescending(x => x.Id);


            return PaginatedList<ClientDto>.Create(await clients.ToListAsync(), query.PageIndex, query.PageSize);


        }
    }
}