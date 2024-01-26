using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 13, 37);
        string verse = "And ablessed are they who shall seek to bring forth my Zion at that day, for they shall have the gift and the power of the Holy Ghost; and if they endure unto the end they shall be lifted up at the last day, and shall be saved in the everlasting kingdom of the Lamb; and whoso shall publish peace, yea, tidings of great joy, how beautiful upon the mountains shall they be.";
        
        Scripture scripture = new Scripture(reference, verse);
        string response = "";
        while(response != "quit")
        {
            Console.Clear();
            Console.Write($"{reference.GetDisplayText()} ");
            Console.WriteLine($"{scripture.GetDisplayText()} ");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            if(response == "quit")
            { break; }
            scripture.HideRandomWords(3);
            if(scripture.IsCompletelyHidden())
            { response = "quit"; }
        }
        Console.Clear();
        Console.Write($"{reference.GetDisplayText()} ");
        Console.WriteLine($"{scripture.GetDisplayText()} ");
    }
}