using System;
using System.Collections.Generic;

public class Program
{
    public string filename;
    static void Main(string[] args)
    {
        Console.WriteLine("What file do you want to use for the journal?");
        filename = Console.ReadLine();
    }
}