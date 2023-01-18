using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        List<string> entriesList = new List<string>();

        do
        {
            // Task options to choose from for journaling.
            Console.WriteLine("Welcome to Your Journal!");
            Console.WriteLine("Please select from the following options:");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Add Prompt (Extra Credit)");
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
                Entry newEntry = new Entry(entriesList);
                newEntry.Display();
                entriesList = newEntry._entries;
            }

            else if (selection == 2)
            {
                //View entries
                View newView = new View(entriesList);
                newView.Display(); 
            }

            else if (selection == 3)
            {
                //Add a new prompt
                WritePrompt newPrompt = new WritePrompt();
                newPrompt.Display(); 
            }

            else if (selection == 4)
            {
                Load newLoad = new Load();
                newLoad.Display(); 
                entriesList = newLoad._entries;
            }

            else if (selection == 5)
            {
                //still having difficulty with this.
                Save newSave = new Save(entriesList);
                newSave.Display(); 
            }

        }

        while (selection != 6);
        Console.WriteLine("Thanks for using this program");
    }
}

public class Entry
{
    public string _writing;
    public string _dateTime;
    public List<string> _entries;

    public string prompt = "";
    public Entry(List<string> entries)
    {
        _entries = entries;
    }
    
    public List<String> Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Prompt newPrompt = new Prompt();
        newPrompt.Display();
        prompt = newPrompt._prompt;

        Console.Write("> ");
        _writing = Console.ReadLine();
       
        _entries.Add($"{dateText} {prompt} \n{_writing}\n");

        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
        return _entries;
    }

} 

public class Prompt
{
    public string _prompt;

    public string Display()
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

        _prompt = question;

        return _prompt;
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
            outputFile.Write($"\n{prompt}|");
        }

    }   
}

public class View
{
    public List<string> _entries;

    
    public View(List<string> entries)
    {
        _entries = entries;
    }
    public void Display()
    {

    foreach (var entry in _entries)
        {
            Console.WriteLine($"{entry}\n");
        }
    }
}

public class Load
{
    public string _fileName;
    public List<string> _entries = new List<string>();

    public List<String> Display()
    {
        Console.Write("What is the file name? ");
        _fileName = Console.ReadLine()+".txt";

        string filename = _fileName;
        string[] lines = System.IO.File.ReadAllLines(filename);        

        foreach (string line in lines)
        {
            Console.WriteLine(line);
            _entries.Add(line);
        }
        return _entries;
    }
}

public class Save
{
    public List<string> _entries;
    public string _fileName;
    public Save(List<string> entries)
    {
        _entries = entries;
    }
    public void Display()
    {
      
        Console.Write("What would you like to save this as? ");
        _fileName = Console.ReadLine()+".txt";

        string fileName = _fileName;

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry}");
            }
        }
    }
}