using Domain.Enums;

namespace Domain.Entities;

public class Account
{
    public int Id { get;private set; }
    public string IPAN { get; private set; }
    public AccountType AccountType { get; private set; }
}
