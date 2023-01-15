using System;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        do
        {
            // Task options to choose from.
            Console.WriteLine("Welcome to Your Journal!");
            Console.WriteLine("Please select from the following options:");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            Console.Write("What would you like to do? ");

            //Read input and change to interger.
            string choice = Console.ReadLine();
            selection = int.Parse(choice);

            // check it is working
            // Console.Write(choice);

            if (selection == 1)
            {
                Entry newEntry = new Entry();
                // newEntry._choice = 1;
                newEntry.Display();
            }
        }
        while (selection != 5);
        Console.WriteLine("Thanks for using this program");
    }
}

public class Entry
{
    public string _writing;

    public void Display()
    {
        {
            Prompt newPrompt = new Prompt();
            newPrompt.Display();

            // Console.Write("> ");
            // _writing = Console.ReadLine();
            // Console.WriteLine(_writing);
        }
    }
}

public class Prompt
{
    Random randomGenerator = new Random();

    string filename = "prompts.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);

    int count = 0;

    public void Display()
    {
            // Prompt newPrompt = new Prompt();
            // newPrompt._prompt = 0;
            // newPrompt.Display();
        foreach (string line in lines)
        {
            count = count + 1;
            string[] parts = line.Split("|");
        
        int number = randomGenerator.Next(count);

        string prompt = parts[number];


        Console.WriteLine($"{prompt}");
        }
    }
        
}