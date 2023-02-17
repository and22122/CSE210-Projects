using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       Menu m = new Menu();
       Journal j = new Journal();

       m.addPrompts();

       string repeatMain = "y";

       do
       {
            m.showOptions();

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string p = m.getPrompt();

                Console.Write(p);
                Console.WriteLine(" Please enter a response and hit enter. Avoid using the '|' symbol.");

                string r = Console.ReadLine();

                Entry e = new Entry();
                e._dateString = DateTime.Now.ToShortDateString();
                e._prompt = p;
                e._response = r;

                j.addEntry(e);
            }
            else if (userChoice == "2")
            {
                j.displayEntries();
            }
            else if (userChoice == "3")
            {
                j.saveEntries();
            }
            else if (userChoice == "4")
            {
                j.loadEntries();
            }

            Console.WriteLine("Continue? (y to continue; other inputs will end the program)");

            repeatMain = Console.ReadLine();
       } while (repeatMain == "y");
    }
}