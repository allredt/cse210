class ReflectingActivity : Activity
{
    List<string> _prompt, _questions;
    private int count;
    public ReflectingActivity() : base()
    {
        activityName = "Reflecting Activity";
        activityDescription = ("This activity will help you reflect on times in your life when you have"+
        " shown strength and resilience. This will help you recognize the power you have" +
        " and how you can use it in other aspects of you life.");
        
        _prompt = new List<string>
        {
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }
    public void runReflectingActivity()
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
        
        Console.WriteLine("Consider the following:");
        Console.WriteLine();

        int randomNumber = new Random().Next(0, _prompt.Count());
        Console.WriteLine(_prompt[randomNumber]);

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following as they relate to this experience.");
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

        for (int i = 0; i <4; i++)
        {
            count +=1;
            int randomNumber = new Random().Next(0, _questions.Count());
            while (indexes.Contains(randomNumber))
            {
                randomNumber = new Random().Next(0, _questions.Count());
            }
            indexes.Add(randomNumber);
        }
        foreach (int index in indexes)
        {
            Console.Write(_questions[index]);
            displaySpinner((lengthInput / indexes.Count()));
            Console.WriteLine();
        }
    }
    
}