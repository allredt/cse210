using System;


// string filename = "prompts.txt";
// string[] lines = System.IO.File.ReadAllLines(filename);

// foreach (string line in lines)
// {
//     string[] parts = line.Split("|");

//     string prompt1 = parts[0];
//     string prompt2 = parts[1];
//     Console.WriteLine($"{prompt1}");
// }

class promptS
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        string filename = "prompts.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        int count = 0;

        foreach (string line in lines)
        {
            count = count + 1;
            string[] parts = line.Split("|");
        }
        int number = randomGenerator.Next(count);

        string prompt = parts[number];

        Console.WriteLine($"{prompt}");

        // foreach (string line in lines)
        // {
        //     string[] line = line.Split("|");

        //     string first = parts[0];
        //     Console.Write($"{parts[0]}");
            // string second = parts[1];
            // Console.Write($"{parts[1]}");

            // string prompt = parts[3];
        }

        // Console.WriteLine($"{prompt}");

    }
}

