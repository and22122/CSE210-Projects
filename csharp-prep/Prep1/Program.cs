using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fn = Console.ReadLine();

        Console.Write("What is your last name? ");
        string ln = Console.ReadLine();

        Console.WriteLine("");
        Console.Write("Your name is ");
        Console.Write(ln);
        Console.Write(", ");
        Console.Write(fn);
        Console.Write(" ");
        Console.Write(ln);
        Console.WriteLine(".");
    }
}