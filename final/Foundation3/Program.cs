using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Introduction to C#", "Learn the basics of C#", 120, "10/31/2023", "123 Main Street", "John Smith", 50);
        Reception reception = new Reception("Birthday Party", "Celebrate your special day with a party", "11/1/2023", "1523 Main Street", 1200, "QqO6N@example.com");
        Outdoor outdoor = new Outdoor("Hiking Trip", "Hike to the top of a mountain", "6/2/2024", "1643 Main Street", 1800, "Sunny");

        Console.Clear();

        Console.WriteLine("Short Description:");
        lecture.DisplayShortDescription();
        Console.WriteLine("\nStandard Details:");
        lecture.DisplayStanardDetails();
        Console.WriteLine("\nFull Details:");
        lecture.DisplayFullDetails();

        Console.WriteLine("Short Description:");
        reception.DisplayShortDescription();
        Console.WriteLine("\nStandard Details:");
        reception.DisplayStanardDetails();
        Console.WriteLine("\nFull Details:");
        reception.DisplayFullDetails();

        Console.WriteLine("Short Description:");
        outdoor.DisplayShortDescription();
        Console.WriteLine("\nStandard Details:");
        outdoor.DisplayStanardDetails();
        Console.WriteLine("\nFull Details:");
        outdoor.DisplayFullDetails();
    }
}