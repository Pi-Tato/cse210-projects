using System;
using System.IO;

public class Journal
{
    public void Save(List<string> entries, string date, List<string> prompts)
    {
        Console.WriteLine("What do you want to name this file? (add '.txt' at the end)");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            for(int i = 0; i < entries.Count(); i++)
            {
                outputFile.WriteLine($"Date: {date} - Prompt: {prompts[i]}");
                outputFile.WriteLine(entries[i]);
                outputFile.WriteLine("");

            }
        }
    }

    public void Load()
    {
        Console.WriteLine("What file do you want to load? ");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);

        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("");
    }
}