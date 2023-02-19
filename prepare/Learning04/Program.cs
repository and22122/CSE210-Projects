using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment m1 = new MathAssignment("Jalen Anderson", "Math", "1.2", "3-8");
        WritingAssignment w1 = new WritingAssignment("Jalen Anderson", "Writing", "Essay 1");

        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}