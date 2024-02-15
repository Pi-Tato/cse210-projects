using System;

public class Comment
{
    string _name;
    string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    public void Display()
    {
        Console.WriteLine($"{_name}: {_text}");
    }
}