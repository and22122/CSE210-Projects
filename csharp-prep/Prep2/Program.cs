using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gp = Console.ReadLine();
        int gpn1 = int.Parse(gp) / 10;
        int gpn2 = int.Parse(gp) - 10 * gpn1;
        int gpn = 10 * gpn1 + gpn2;

        Console.Write("Your grade was ");

        char letter;

        if (gpn >= 90)
        {
            letter = 'A';
        }
        else if (gpn >= 80)
        {
            letter = 'B';
        }
        else if (gpn >= 70)
        {
            letter = 'C';
        }
        else if (gpn >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        string sign = "";

        if (gpn2 >= 7)
        {
            sign = "+";
        }
        else if (gpn2 < 3) {
            sign = "-";
        }

        if ((letter == 'A' && sign == "+") || (letter == 'F'))
        {
            sign = "";
        }

        string grade = letter.ToString() + sign;

        if (letter == 'A' || letter == 'F')
        {
            Console.Write("an ");
        }
        else {
            Console.Write("a ");
        }

        Console.Write(grade);

        Console.Write(" which means you ");

        if (gpn >= 70)
        {
            Console.Write("passed! Good job!");
        }
        else
        {
            Console.Write("failed. Nice try!");
        }
    }
}