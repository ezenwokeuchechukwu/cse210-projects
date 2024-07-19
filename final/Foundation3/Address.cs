using System;

public class Address
{
    private string Street { get; }
    private string City { get; }
    private string State { get; }
    private string ZipCode { get; }

    public Address(string street, string city, string state, string zipCode)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State}, {ZipCode}";
    }
}
