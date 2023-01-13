using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int newNum = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            newNum = int.Parse(Console.ReadLine());

            if (newNum != 0)
            {
                numberList.Add(newNum);
            }
        } while (newNum != 0);

        int counter = 0;

        foreach (int num in numberList)
        {
            counter += num;
        }

        Console.Write("The sum is: ");
        Console.WriteLine(counter);

        float average = (float)counter / numberList.Count;
        
        Console.Write("The average is: ");
        Console.WriteLine(average);

        int biggestNum = 0;

        foreach (int num in numberList)
        {
            if (num > biggestNum)
            {
                biggestNum = num;
            }
        }

        Console.Write("The largest number is: ");
        Console.WriteLine(biggestNum);
    }
}