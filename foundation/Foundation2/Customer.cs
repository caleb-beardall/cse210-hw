using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address newAddress)
    {
        _name = name;
        _address = newAddress;
    }

    public string GetName()
    {
        string name = _name;
        return name;
    }
    
    public string GetAddress()
    {
        string address = _address.GetAddress();
        return address;
    }

    public bool IsInUSA()
    {
        bool isTrue = _address.IsInUSA();
        return isTrue;
    }
}