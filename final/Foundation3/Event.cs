using System;

public class Event
{
    protected string _title, _description, _date, _address;
    protected int _time;

    public Event(string title, string description, string date, string address, int time)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
        _time = time;
    }
}