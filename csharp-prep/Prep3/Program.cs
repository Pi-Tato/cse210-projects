using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(1, 101);

        int numGuesses = 0;
        int guess = -1;
        while (guess != randNumber)
        {
            Console.Write("Guess the number. ");
            guess = int.Parse(Console.ReadLine());

            if (randNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (randNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            numGuesses++;
        }
        Console.WriteLine($"It took you {numGuesses} guesses!");
    }
}