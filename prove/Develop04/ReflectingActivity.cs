using System;

public class ReflectingActivity : Activity
{
    private string name = "Reflecting Activity",
    discription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    List<string> _prompts = new List<string>
    {
        "--- Think about a goal you set and achieved this year. ---",
        "--- Think about a situation where you had to handle intense pressure this year. ---",
        "--- Think about a time you had to manage conflicting priorities this year. ---",
        "--- Think about a weakness you have overcome this year. ---",
        "--- Think about a experience where your weakness made you suffer this year. ---",
        "--- Think about any leadership experience you had this year. ---",
        "--- Think about a situation where you had an difference of opinion with someone yet you were centered. ---",
        "--- Think about a time you had to persuade someone and you could. ---",
        "--- Think about something you learned quickly. ---",
        "--- Think about how you see yourself around the same time next year. ---"
    };
    List<string> _questions = new List<string>
    {
        "> What do I wish I did differently in the past year?",
        "> Have I maintained a good work-life balance in the past year?",
        "> What are some challenges I've overcome recently?",
        "> What past experiences helped me make important decisions?",
        "> If I could go back in time, what might I do differently?",
        "> What accomplishment from the past year surprised me?",
        "> What's the most courageous decision I've made?",
        "> How does where I am now compared to where I expected to be at this point 10 years ago?",
        "> What am I most proud of?",
        "> What's a significant risk I took that had a positive outcome, and what did it teach me?"
    };
    private int duration;

    public ReflectingActivity()
    :base()
    {
        _name = name;
        _discription = discription;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like this session? ");
        duration = int.Parse(Console.ReadLine());
        _duration = duration;

        Console.WriteLine("Get Ready...");
        ShowSpinner(8);
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();
        
        int i = 0;
        while(i < duration)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(10);
            i += 10;
        }

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(0, _prompts.Count())];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(0, _questions.Count())];
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {
        
    }

}