using Domain.Enums;

namespace Application.Client.Commands.Queries.GetClients
{
    public class AccountDto
    {
        public int Id { get; private set; }
        public string IPAN { get; private set; }
        public AccountType AccountType { get; private set; }
    }
}