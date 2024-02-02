using System;

public class BreathingActivity : Activity
{
    private string name = "Breathing Activity", 
    discription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    private int duration;

    public BreathingActivity()
    : base()
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
        for (int i = 0; i < _duration / 10; i++)
        {
            Console.WriteLine("");
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Breath out...");
            ShowCountDown(6);
        }
        DisplayEndingMessage();
    }
}