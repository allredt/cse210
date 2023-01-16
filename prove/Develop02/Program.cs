using System.IO;

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
            Console.WriteLine("3. Add Prompt ");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Save ");
            Console.WriteLine("6. Quit ");
            Console.Write("What would you like to do? ");

            //Read input and change to interger.
            string choice = Console.ReadLine();
            selection = int.Parse(choice);

            // check it is working
            // Console.Write(choice);

            if (selection == 1)
            {
                Entry newEntry = new Entry();
                newEntry.Display();
            }
            else if (selection == 2)
            {
                // View newView = new View();
                // newView.Display(); 
            }
            else if (selection == 3)
            {
                WritePrompt newPrompt = new WritePrompt();
                newPrompt.Display(); 
            }
        }
        while (selection != 5);
        Console.WriteLine("Thanks for using this program");
    }
}

public class Entry
{
    public string _writing;
    public string _dateTime;
    public List<string> _entries = new List<string>();

    
    public List<String> Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Prompt newPrompt = new Prompt();
        newPrompt.Display();

        Console.Write("> ");
        _writing = Console.ReadLine();
       
        _entries.Add($"{dateText}" + Environment.NewLine + $"{_writing}" + Environment.NewLine);

        return _entries;
    }

} 

public class Prompt
{
    public void Display()
    {
        Random randomGenerator = new Random();

        string filename = "prompts.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        int count = 0;
        
        List<string> prompts = new List<string>();

        foreach (string line in lines)
        {
            count = count + 1;
            string[] prompt = line.Split("|");
            prompts.Add(prompt[0]);
        }

        int number = randomGenerator.Next(0, count);
        
        string question = prompts[number];

        Console.WriteLine(question); 

    }   
}

public class WritePrompt
{
    public void Display()
    {
        Console.WriteLine("What would you like the prompt to say? ");
        string prompt = Console.ReadLine();
        

        string filename = "prompts.txt";
        
        using (StreamWriter outputFile = File.AppendText(filename))
        {
            outputFile.WriteLine($"{prompt}|"+ Environment.NewLine);
        }

    }   
}

public class Journal
{
    public void Display()
    {

    }
}

// public class View(_entries)
// {
//     public void Display()
//     {
//     foreach (var entry in _entries)
//         {
//             Console.WriteLine($"{entry}");
//         }
//     }
// }