using System;

public class Job
{
    public string _jobTitle, _company;
    public int _startYear, _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}