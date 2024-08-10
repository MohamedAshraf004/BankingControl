using Domain.Enums;

namespace Application.Client.Commands.Create
{
    public class AccountInput
    {
        public string IPAN { get; set; }
        public AccountType AccountType { get; set; }
    }
}