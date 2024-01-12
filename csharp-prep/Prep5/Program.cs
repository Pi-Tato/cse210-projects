using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Welcome());
        Console.WriteLine("What's your name? ");
        string name = GetName();
        Console.WriteLine("What's your favorite number? ");
        float favNum = FavoriteNumber();
        Console.WriteLine($"{name}, the squrare of {favNum} is {GetNumberSquared(favNum)}");

    }
    static string Welcome()
    {
        return "Welcome to my program!";
    }
    static string GetName()
    {
        return Console.ReadLine();
    }
    static float FavoriteNumber()
    {
        string num = Console.ReadLine();
        return float.Parse(num);
    }
    static float GetNumberSquared(float num)
    {
        return num * num;
    }
}