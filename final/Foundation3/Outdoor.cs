using System;

public class Outdoor : Event
{
    string _weather;

    public Outdoor(string title, string description, string date, string address, int time, string weather) 
    : base(title, description, date, address, time)
    {
        _weather = weather;
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
        Console.WriteLine($"Its a {_title} ({_description}) on {_date} at {_address}. Wheather: {_weather}.\n");
    }
}