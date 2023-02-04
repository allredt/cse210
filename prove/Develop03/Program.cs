using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Proverbs", "3", "5-6");
        Scripture scripture = new Scripture(scriptureReference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        string  userInput = "";

        while (userInput != "quit" || scriptureMemorizer.hasWordsLeft() < 9)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            Console.WriteLine();
            Console. WriteLine($"Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            scriptureMemorizer.removeWordsFromText();
        }
    }
}