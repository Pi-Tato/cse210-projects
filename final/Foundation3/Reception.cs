using System;

public class Reception : Event
{
    string _email;

    public Reception(string title, string description, string date, string address, int time, string email)
    : base(title, description, date, address, time)
    {
        _email = email;
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"Its a {_title} on {_date}.");
    }
    public void DisplayStanardDetails()
    {
        Console.WriteLine($"Its a {_title} ({_description}) on {_date} at {_address}.");
    }
    public void DisplayFullDetails()
    {
        Console.WriteLine($"Its a {_title} ({_description}) on {_date} at {_address}. Email: {_email}.\n");
    }
}