using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        
        string letterGrade = "";
        if(grade <= 60)
        {
            letterGrade = "F";
        }else if(grade <= 69)
        {
            letterGrade = "D";
        }else if(grade <= 79)
        {
            letterGrade = "C";
        }else if(grade <= 89)
        {
            letterGrade = "B";
        }else
        {
            letterGrade = "A";
        }

        if(letterGrade == "C" || letterGrade == "B")
        {
            Console.WriteLine($"You got a {letterGrade}! You passed!");
        }else if(letterGrade == "A")
        {
            Console.WriteLine($"You got an {letterGrade}! You passed!");
        }else if(letterGrade == "F")
        {
            Console.WriteLine($"You got an {letterGrade}... Better luck next time.");
        }else
        {
            Console.WriteLine($"You got a {letterGrade}. Try again.");
        }
    }
}