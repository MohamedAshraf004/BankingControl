using Domain.Enums;
using MediatR;

namespace Application.Client.Commands.Create;

public class CreateClientCommand : IRequest<CreateClientCommandResponse>
{
    public string PersonalKey { get; set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string PhotoUrl { get; private set; }
    public Gender Gender { get; private set; }
    public string MobileNumber { get; private set; }
    public AddressInput Address { get; private set; }
    public ICollection<AccountInput> Accounts { get; private set; } = [];
}