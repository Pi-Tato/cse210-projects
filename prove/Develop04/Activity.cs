using System;

public class Activity
{
    protected string _name, _discription;
    protected int _duration;

    public Activity()
    { }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_discription);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        ShowSpinner(8);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinners = new List<string>
        {
            "/", "-", "\\", "|",
            "/", "-", "\\", "|",
            "/", "-", "\\", "|"
        };
        int i = 0;
        while(i < seconds)
        {
            Console.Write(spinners[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
        }
    }
    public void ShowCountDown(int seconds)
    {
        int i = seconds;
        while(i > 0)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
    }
}