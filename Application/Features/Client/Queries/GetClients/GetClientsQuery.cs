﻿using Domain.Enums;
using MediatR;

namespace Application.Features.Client.Queries.GetClients
{
    public class GetClientsQuery : IRequest<GetClientsQueryResponse>
    {
        public string ClientName { get; set; }

        public string Email { get; set; }

        public Gender? Gender { get; set; }

        public bool OrderByDesc { get; set; }

        public int PageIndex { get; set; } = 1;

        public int PageSize { get; set; } = 10;


    }
}