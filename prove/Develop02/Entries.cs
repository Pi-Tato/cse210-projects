using System;

public class Entry
{
    public List<string> entries = new List<string>();
    DateTime date = DateTime.Now;

    public void Display(List<string> prompts)
    {
        for(int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine($"Date: {date.ToShortDateString()} - Prompt: {prompts[i]}");
            Console.WriteLine(entries[i]);
            Console.WriteLine("");
        }
    }
}