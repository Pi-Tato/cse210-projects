using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Jack Fredricson", "Addition");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Ian Solo", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHoeworkList());

        WritingAssignment a3 = new WritingAssignment("Luke Bennet", "European History", "World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());
    }
}