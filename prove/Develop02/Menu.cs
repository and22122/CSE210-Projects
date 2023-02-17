using System;
using System.Collections.Generic;

public class Menu
{
    List<string> _prompts = new List<string>();

    public void addPrompts() {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What am I most grateful for today?");
        _prompts.Add("What was my favorite part of the day?");
        _prompts.Add("What is one way in which I can improve?");
        _prompts.Add("How can I serve someone tomorrow?");
        _prompts.Add("On a scale of 1 to 10, how would I rate my day and why?");
    }

    public string getPrompt()
    {
        Random randGen = new Random();
        
        int promptNum = randGen.Next(0, _prompts.Count());

        return _prompts[promptNum];
    }

    public void showOptions() {
        Console.WriteLine("What do you want to do? (please type a number and press enter)");
        Console.WriteLine("1- Write a new entry");
        Console.WriteLine("2- Display the journal");
        Console.WriteLine("3- Save the journal to a file");
        Console.WriteLine("4- Load the journal from a file");
    }
}