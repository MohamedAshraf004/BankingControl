using Domain.Enums;
using MediatR;

namespace Application.Features.Client.Commands.Create;

public class CreateClientCommand : IRequest<CreateClientCommandResponse>
{
    public string PersonalKey { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhotoUrl { get; set; }
    public Gender Gender { get; set; }
    public string MobileNumber { get; set; }
    public AddressInput Address { get; set; }
    public ICollection<AccountInput> Accounts { get; set; } = [];
}