using System;

public class Address
{
    string _address, _city, _state, _country;

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool LivesInUSA()
    {
        return _country == "USA";
    }
    public string CombineStrings()
    {
        return $"{_address}, {_city}, {_state}, {_country}";
    }
}