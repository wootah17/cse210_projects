using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        string quitChoice = "";

        while (quitChoice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1- Write");
            Console.WriteLine("2- Display");
            Console.WriteLine("3- Load");
            Console.WriteLine("4- Save");
            Console.WriteLine("5- Quit");

            Console.Write("Enter a choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                journal.LoadFromFile();
            }

            else if (choice == "4")
            {
                journal.SaveToFile();
            }

            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice");
            }


            
        }

    }

}


       