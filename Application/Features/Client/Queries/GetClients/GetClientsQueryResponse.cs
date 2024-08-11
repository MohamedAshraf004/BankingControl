using Application.Common.Helpers;
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
        public int PageIndex => Clients.PageIndex;
        public int TotalPages => Clients.TotalPages;
        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;
    }
}