using Domain.Enums;

namespace Application.Client.Commands.Create
{
    public class AccountInput
    {
        public string IPAN { get; private set; }
        public AccountType AccountType { get; private set; }
    }
}