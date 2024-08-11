using Domain.Enums;

namespace Application.Features.Client.Queries.GetClients
{
    public class ClientDto
    {
        public int Id { get; private set; }
        public string PersonalKey { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhotoUrl { get; private set; }
        public Gender Gender { get; private set; }
        public string MobileNumber { get; private set; }
        public AddressDto Address { get; private set; }
        public ICollection<AccountDto> Accounts { get; private set; } = [];
    }
}