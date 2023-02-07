using System;
using System.Collections.Generic;

public class Menu
{
    entry newEntry;
    List<string> prompts = new List<string>();

    public void CreatePrompts() {
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("What activity did I most enjoy today?");
        prompts.Add("What am I most grateful for today?");
        prompts.Add("How can I improve myself?");
        prompts.Add("What is one of my current goals in life?");
    }

    public string GetUserInput()
    {
        Console.WriteLine("What do you want to do? (press a number key)");
        Console.WriteLine("1. Write a new entry.");
        Console.WriteLine("2. Display a journal entry.");
        Console.WriteLine("3. Load an entry from a file.");
        Console.WriteLine("4. Save an entry to a file.");
        Console.WriteLine("5. Quit.");
        int userChoice = int.Parse(Console.ReadLine());

        return userChoice;
    }

    public void CreateEntry() {
        Console.WriteLine("Would you like a prompt? (y/n)");
        string givePrompt = Console.ReadLine();

        if (givePrompt == "y") {
            Random randGen = new Random();

            promptNum = int.Parse(randGen.Next());
        }
    }
}