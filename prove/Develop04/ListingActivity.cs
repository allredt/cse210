class ListingActivity : Activity
{
    List<string> _prompt;
    private int count;
    public ListingActivity() : base ()
    {
        activityName = "Listing Activity";
        activityDescription = ("This activity will help you reflect on the good things in your life "+
        " by having you list as many things as you can in a certain area.");
        
        _prompt = new List<string>
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };
    }
    public void runListingActivity()
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
        
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        int randomNumber = new Random().Next(0, _prompt.Count());
        Console.WriteLine(_prompt[randomNumber]);

        // Console.WriteLine("You may begin in:");
        // displayCountdown(5);

        displaySpinner(lengthInput);

        count = 0;

        while (lengthInput > 0)
        {
            count +=1;
            Console.Write(">");
            Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine(string.Format("Well Done! You listed {0} things.", count));
        displaySpinner(3);
        Console.WriteLine();

        Console.WriteLine(string.Format("You have completed another {0} seconds of the {1}.",
            lengthInput, activityName));

        Console.WriteLine();
        displaySpinner(3);
    }
}