using System;
using System.Runtime.CompilerServices;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zip;
    private string _country;

    public Address(string street, string city, string state, int zip, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }

    public string GetAddress()
    {
        string address = $"{_street}\n{_city}, {_state} {_zip}\n{_country}";
        return address;
    }

    public bool IsInUSA()
    {
        bool isTrue = true;
        
        if (!(_country == "United States" || _country == "USA"))
        {
            isTrue = false;
        }

        return isTrue;
    }
}