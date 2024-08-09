namespace Domain.ValueObjects;

public struct Address
{
    public string Country { get; private set; }
    public string City { get; private set; }
    public string Street { get; private set; }
    public string PostalCode { get; private set; }

}
