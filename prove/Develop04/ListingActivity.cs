using System;
using System.Net;

public class ListingActivity : Activity
{
    string name = "Listing Activity", 
    discription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    int _count = 0;
    List<string> _prompts = new List<string>
    {
        "--- Who are some of your personal heroes? ---",
        "--- When have you felt the Holy Ghost this month? ---",
        "--- Who are people that you have helped this week? ---",
        "--- Who are some of your personal heroes? ---",
        "--- When have you felt the Holy Ghost this month? ---"
    };

    private int duration;
    private List<string> entries = new List<string>();

    public ListingActivity()
    :base()
    {
        _name = name;
        _discription = discription;
    }
    public void Run()
    {
        string response;

        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like this session? ");
        duration = int.Parse(Console.ReadLine());
        _duration = duration;

        Console.WriteLine("Get ready...");
        ShowSpinner(8);
        Console.WriteLine("");
        Console.WriteLine("List as many reponses to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        
        int i = duration;
        Console.WriteLine("");
        while(i > 0)
        {
            Console.Write("> ");
            response = Console.ReadLine();
            entries.Add(response);
            _count++;
            i -= 3;
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(0, _prompts.Count())];
    }
    public List<string> GetListFromUser()
    {
        return entries;
    }
}