using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your last name? ");
        string name = Console.ReadLine();

        Console.Write("What is your first name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your full name is {name} {lastname} ");

    }
}