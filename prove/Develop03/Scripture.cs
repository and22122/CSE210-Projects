using System;
using System.Collections.Generic;

public class Scripture
{
    private string _reference = "";
    private List<Verse> _verses = new List<Verse>();

    public Scripture()
    {
        System.Console.Write("What is the scripture reference? (e.g. Proverbs 3:5-6)");
        _reference = Console.ReadLine();

        bool keepgoing = true;

        do
        {
            System.Console.WriteLine("What verse do you want to add?");            
            _verses.Add(new Verse(System.Console.ReadLine()));

            System.Console.WriteLine("Would you like to add another verse?(y/n)");
            string input = System.Console.ReadLine();

            keepgoing = (input == "y");
        } while (keepgoing);

        System.Console.WriteLine("Okay. Ending scripture.");
    }

    public void HideWords()
    {
        Random randGen = new Random();
        int iters = (int)(randGen.NextDouble() * 3 + 3);

        for (int i = 0; i < iters; i ++)
        {
            int verseNum = (int)(randGen.NextDouble() * _verses.Count());

            _verses[verseNum].HideRandomWord();
        }
    }

    public bool AllAreHidden()
    {
        bool allblank = true;

        foreach (Verse v in _verses)
        {
            allblank = (allblank && v.AllHidden());
        }

        return allblank;
    }

    public void writeScripture()
    {
        foreach (Verse v in _verses)
        {
            v.GetText();
        }
    }
}