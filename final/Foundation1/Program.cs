using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new("C# Basics", "The Wachowskis", 150),
            new("The History of C#", "The York T.", 110),
            new("Fundamentals of C#", "Stephen", 85),
        };

        Console.Clear();
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine("");
        }
    }
}