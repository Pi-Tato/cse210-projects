using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.Clear();
        DisplayMainMenu();
    }
    static void DisplayMainMenu()
    {
        GoalManger goalManger = new GoalManger();
        string _response = "";
        while(_response != "6")
        {
            Console.WriteLine($"You have {goalManger.GetScore()} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals (If there are goals to load, do that first)");    
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select an option from the menu: ");
            _response = Console.ReadLine();

            switch(_response)
            {
                case "1":
                    Console.WriteLine("");
                    goalManger.Start();
                    break;
                case "2":
                    Console.WriteLine("");
                    goalManger.ListGoals();
                    break;
                case "3":
                    goalManger.SaveGoals();
                    break;
                case "4":
                    goalManger.LoadGoals();
                    break;
                case "5":
                    goalManger.RecordEvent();
                    break;
            }
        }
    }
}
