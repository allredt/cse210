class BreathingActivity : Activity
{
    List<string> _prompt, _questions;
    private int count;
    public BreathingActivity() : base()
    {
        activityName = "Breathing Activity";
        activityDescription = ("This activity will help you relax by walking your through breathing in and out slowly. "+
        "Clear your mind and focus on your breathing");
        
        _prompt = new List<string>
        {
            "--- Breathe in ---",
            "--- Breathe out ---",
        };
        _questions = new List<string>
        {
            "Breathe in",
            "Breathe out",
            "Breathe in",
            "Breathe out",
            "Breathe in",
            "Breathe out",
            "Breathe in",
            "Breathe out",
            "Breathe in",
            "Breathe out",
            "Breathe in",
            "Breathe out",
        };
    }
    public void runBreathingActivity()
    {
        Console.WriteLine(string.Format("Welcome to the {0}.", activityName));
        Console.WriteLine();
        Console.WriteLine(activityDescription);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        lengthInput = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        displaySpinner(5);
        Console.Clear();
        
        displayCountdown(5);

        Console.Clear();
        displayQuestions();

        Console.WriteLine();
        Console.WriteLine("Well Done!");
        displaySpinner(3);
        Console.WriteLine();

        Console.WriteLine(string.Format("You have completed another {0} seconds of the {1}.",
            lengthInput, activityName));

        Console.WriteLine();
        displaySpinner(3);

    }
    public void displayQuestions()
    {
        List<int> indexes = new List<int>();
        count = 0;

        for (int i = 0; i < 4; i++)
        {
            count +=1;
            int number = 0;
            while (indexes.Contains(number))
            {
                number += 1; 
            }
            indexes.Add(number);
        }
        foreach (int index in indexes)
        {
            Console.Write(_questions[index]);
            displaySpinner((lengthInput / indexes.Count()));
            Console.WriteLine();
        }
    }   
}