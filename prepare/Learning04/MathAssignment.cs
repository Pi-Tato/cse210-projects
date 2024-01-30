using System;

public class MathAssignment : Assignment
{
    string _textbookSection = "", _problems = "";

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHoeworkList()
    {
        return $"Section {_textbookSection}: {_problems}";
    }
}