using System;
using System.Collections.Generic;

public class Menu
{
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
}