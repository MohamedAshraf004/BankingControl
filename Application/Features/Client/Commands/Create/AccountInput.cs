using Domain.Enums;

namespace Application.Features.Client.Commands.Create
{
    public class AccountInput
    {
        public string IPAN { get; set; }
        public AccountType AccountType { get; set; }
    }
}