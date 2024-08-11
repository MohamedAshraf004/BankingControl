using Application.Responses;

namespace Application.Features.Client.Commands.Create
{
    public class CreateClientCommandResponse : BaseResponse
    {
        public CreateClientCommandResponse(int clientId) : base()
        {
            ClientId = clientId;
        }

        public int ClientId { get; private set; }
    }
}