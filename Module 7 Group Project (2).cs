using System.Collections.Generic;

class Program
{
    //Attributes
    static Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

    //Functions
    static void PopulateDictionary()
    {
        myDictionary["red"] = new List<string> { "color", "passion", "energy" };
        myDictionary["banana"] = new List<string> { "fruit", "yellow", "tropical" };
        myDictionary["France"] = new List<string> { "country", "Europe", "wine" };
        myDictionary["elephant"] = new List<string> { "animal", "large", "intelligent" };
        myDictionary["Python"] = new List<string> { "language", "general-purpose", "object-oriented"};
    }

    static void DisplayDictionary()
    {
        Console.WriteLine("Dictionary Contents:");
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
        }
    }

    static void Main(String[] args)
    {
        //Keep running the program until user exits
        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("a. Populate the Dictionary");
            Console.WriteLine("b. Display Dictionary Contents");
            Console.WriteLine("c. Remove a Key");
            Console.WriteLine("d. Add a New Key and Value");
            Console.WriteLine("e. Add a Value to an Existing Key");
            Console.WriteLine("f. Sort the Keys");
            Console.WriteLine("q. Quit");

            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "a":
                    PopulateDictionary();
                    break;
                case "b":
                    DisplayDictionary();
                    break;
                case "q":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}


