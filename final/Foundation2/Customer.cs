using System;

public class Customer
{
    string _name;
    Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetInfo()
    {
        return $"{_name}, {_address.CombineStrings()}";
    }

    public bool LivesInUSA()
    {
        return _address.LivesInUSA();
    }
}