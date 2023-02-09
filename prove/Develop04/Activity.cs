using System.Diagnostics;

public class Activity
{
    protected int lengthInput;
    private int spinnerCounter;
    protected string activityName, activityDescription;
    public bool displaySpinner(int lengthToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        bool timeRemaining = true;

        while(stopwatch.ElapsedMilliseconds / 1000 < lengthToRun)
        {
            spinnerCounter++;
            switch(spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write(" ");
        if (stopwatch.ElapsedMilliseconds / 1000 >= lengthToRun)
        {
            timeRemaining = false;
        }
        return timeRemaining;
    }

    public void displayCountdown(int lengthToRun)
    {
        for (int i = 1; i <= lengthToRun; i++)
        {
            Console.Write(string.Format("You may begin in: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000); 
        }
    }
}