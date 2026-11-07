using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    private List<string> _prompts = new List<string>
    {
        "What was the best moment of your day?",
        "What did you learn today?",
        "Who made you happy today?",
        "What are you grateful for today?",
        "What would you like to improve tomorrow?"
    };

    private Random _random = new Random();

    public void AddEntry()
    {
        int index = _random.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine() ?? "";

        string date = DateTime.Now.ToShortDateString();

        Entry entry = new Entry(date, prompt, response);
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine() ?? "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }

        Console.WriteLine("Journal saved!");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine() ?? "Journal.txt";

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded!");
    }
}