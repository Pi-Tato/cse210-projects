using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();

        

        string response = "";
        while(response != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select an option from the menu: ");
            response = Console.ReadLine();

            if(response == "1")
            {
                Console.Clear();
                breathingActivity.Run();
            }else if(response == "2")
            {
                Console.Clear();
                reflectingActivity.Run();
            }else if(response == "3")
            {
                Console.Clear();
                listingActivity.Run();
            }
        }
    }
}