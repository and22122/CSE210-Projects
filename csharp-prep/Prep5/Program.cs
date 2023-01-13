using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");

        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult()
    {
        string userName = PromptUserName();

        int userNum = PromptUserNumber();

        Console.Write(userName);
        Console.Write(", the square of your number is ");
        Console.Write(SquareNumber(userNum));
    }
}