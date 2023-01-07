using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = QuestionName();
        int number = QuestionNumber();

        int squareNumber = SquareNumber(number);

        Print(name, squareNumber);
       

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string QuestionName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int QuestionNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void Print(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

    }
}