using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Client
{
    public int Id { get; private set; }
    public string PersonalKey { get; set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string PhotoUrl { get; private set; }
    public Gender Gender { get; private set; }
    public string MobileNumber { get; private set; }
    public Address Address { get; private set; }
    public ICollection<Account> Accounts { get; private set; } = [];
}
