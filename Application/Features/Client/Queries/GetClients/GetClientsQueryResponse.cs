﻿using Application.Common.Helpers;
using Application.Responses;

namespace Application.Client.Queries.GetClients
{
    public class GetClientsQueryResponse : BaseResponse
    {
        public GetClientsQueryResponse(PaginatedList<ClientDto> clients)
        {
            Clients = clients;
        }

        public PaginatedList<ClientDto> Clients { get; set; }
    }
}