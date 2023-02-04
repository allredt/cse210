using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the mindfulness program, please choose an number from below:");
        Console.WriteLine("1 - Breathing Activity");
        Console.WriteLine("2 - Reflecting Activity");
        Console.WriteLine("3 - Listing Activity");
        Console.WriteLine("What would you like to do? ");
        string option = Console.ReadLine();
        int choice = int.Parse(option);

    }
}