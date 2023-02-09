using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;

        List<string> menu = new List<string>
        {
            "Menu Options: ",
            "1. Breathing Activity",
            "2. Reflecting Activity",
            "3. Listing Activity",
            "4. Quit"
        };
        while (userInput != 4)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from above. ");
            userInput = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userInput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.runBreathingActivity();
                    break;
                case 2:

                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.runReflectingActivity();
                    break;

                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.runListingActivity();
                    break;
                case 4: 
                    Console.Clear();
                    break;
            }
        }   
        Console.WriteLine("What would you like to do? ");
        string option = Console.ReadLine();
        int choice = int.Parse(option);
    }
}