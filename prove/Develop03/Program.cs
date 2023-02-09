using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture scrip = new Scripture();

        bool repeatloop = true;

        do
        {
            System.Console.Write("Do you want to continue? type Enter to continue; type quit to quit");
            string input = System.Console.ReadLine();
            
            if (input == "quit")
            {
                repeatloop = false;
            }
            else if (input == "")
            {
                repeatloop = true;
            }

            if (scrip.AllAreHidden())
            {
                repeatloop = false;
            }
        } while (repeatloop);
    }
}