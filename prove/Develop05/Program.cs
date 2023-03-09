using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Goals goalList = new Goals();
        bool keepGoing = true;

        Console.Write("Hi! ");

        do
        {
            int option = 0;

            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Display your score");
            Console.WriteLine("2. Create a new goal");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Show the list of goals");
            Console.WriteLine("5. Save the list of goals");
            Console.WriteLine("6. Load a list of goals");
            Console.WriteLine("7. Exit the program");
            Console.WriteLine("Please type a number.");

            do
            {
                option = int.Parse(Console.ReadLine());

                if (option == 0)
                {
                    Console.WriteLine("Please try again.");
                }
            }
            while (option < 1 || option > 7);

            if (option == 1)
            {
                Console.WriteLine($"Your score is {goalList.GetScore()} points.");
            }
            else if (option == 2)
            {
                goalList.MakeGoalFromInput();
            }
            else if (option == 3)
            {
                goalList.RecordEvent();
            }
            else if (option == 4)
            {
                goalList.PrintGoals();
            }
            else if (option == 5)
            {
                goalList.SaveGoals();
            }
            else if (option == 6)
            {
                goalList.LoadGoals();
            }
            else if (option == 7)
            {
                keepGoing = false;
            }

            if (keepGoing)
            {
                Console.WriteLine("Do you wish to keep going? (Press 'y' to continue)");
                keepGoing = (keepGoing && (Console.ReadLine().ToLower() == "y"));
            }
        }
        while(keepGoing);

        Console.WriteLine("You failed to type 'y'. Ending program.");
    }
}