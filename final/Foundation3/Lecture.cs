using System;

public class Lecture : Event
{
    private string _speakerName;
    int _capcity;

    public Lecture(string title, string description, int time, string date, string address, string speakerName, int capacity)
    : base(title, description, date, address, time)
    {
        _speakerName = speakerName;
        _capcity = capacity;
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
        Console.WriteLine($"Its a {_title} ({_description}) on {_date} at {_address}. {_speakerName} will be speaking. There will be {_capcity} people.\n");
    }

}