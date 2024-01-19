using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        Journal journal = new Journal();
        DateTime dateTime = DateTime.Now;

        int journalNumber = 0;
        List<string> prompts = new List<string>{};

        while(journalNumber != 5)
        {
            journalNumber = DisplayOptions();
            if(journalNumber == 1)
            {
                prompts.Add(Write(entry));
            }else if(journalNumber == 2)
            {
                entry.Display(prompts);
            }else if(journalNumber == 3)
            {
                journal.Save(entry.entries, dateTime.ToShortDateString(), prompts);
            }else if(journalNumber == 4)
            {
                journal.Load();
            }
        }
        Console.WriteLine("Have a good day!");
    }

    static string Write(Entry entry)
    {
        string prompt = RandomPrompt();
        Console.WriteLine(prompt);
        string userInput = Console.ReadLine();
        
        entry.entries.Add(userInput);

        return prompt;
    }

    

    static int DisplayOptions()
    {
        List<int> validNumbers = new List<int>
        {
            1, 2, 3, 4, 5
        };

        bool isValidNum = false;

        int response = 0;
        while(isValidNum == false)
        {
            Console.WriteLine("Please choose one of the following.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            response = int.Parse(Console.ReadLine());

            foreach(int number in validNumbers)
            {
                if(validNumbers.Contains(response))
                {
                    isValidNum = true;
                    break;
                }else
                {
                    Console.WriteLine("That's not a valid number.");
                    break;
                }
            }
        }

        return response;
    }


    static string RandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,11);
 
        List<string> writingPrompts = new List<string>
        {
            "How am I feeling today?", "How does my body feel today?", "What am I nervous or anxious about today?",
            "What actions can I take on each of the things that make me nervous or anxious?", "What are my top priorities for the day?", 
            "What is something I can do to make today amazing?", "What did I learn today? How can I apply this knowledge in the future?",
            "What challenges did I face today? How did I overcome them? What can I learn from these experiences?",
            "What did I do today that brought me joy or fulfillment? How can I incorporate more of these activities into my daily routine?",
            "What was a moment of joy, delight, or contentment today?", "What was a small detail I noticed today?", "What was the weather like today?"
        };

        return writingPrompts[randomNumber];
    }
}