using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade in percent: ");
         string answer = Console.ReadLine();

         int x = int.Parse(answer);
         int v = 90;
         int w = 80;
         int y = 70;
         int z = 60;

         string letter = "";

         if (x >= v)
        {
            letter = "A";
        }

        else if (x >= w)
        {
            letter = "B";
        }

        else if (x >= y)
        {
            letter = "C";
        }

        else if (x >= z)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter is {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulation, you pass");
        }

        else
        {
            Console.WriteLine("Sorry you failed, retry on another time");
        }
    }
}