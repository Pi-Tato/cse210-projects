using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when done.");
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            if(number != 0)
            {
                numbers.Add(number);
            }
        }
        int total = 0;
        for(int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];
        }
        float average = ((float)total) / numbers.Count;
        Console.Write($"The sum is {total}, and the average is {average}. ");
        int max = 0;
        foreach(int num in numbers)
        {
            if(max < num)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is {max}.");
    }
}