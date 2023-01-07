using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (number != 0)
        {        
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        int sum = 0;
        int count = 0;
        int largest = 0;
        foreach (int i in numbers)
        {
            sum = sum + i;
            count = count + 1;
            if (i > largest)
            {
                largest = i;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
       
        count = count -1;
        int avg = sum / count;
        Console.WriteLine($"The average is: {avg}");

        Console.WriteLine($"The largest number is: {largest}");

        
    }
}