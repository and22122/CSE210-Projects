using System;
using System.Collections.Generic;
using System.IO;

public class data
{
    List<string> _entryList = new List<string>();

    public void getEntries()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _entryList.Add(line);
        }
    }

    public string Load()
    {
        Console.WriteLine("Which entry would you like to load? (please enter a number)");
        int entryNum = int.Parse(Console.ReadLine());

        return _entryList[entryNum];
    }
    
    public void Save(string saveString)
    {
        Console.WriteLine("What file do you want to save to?");
        string filename = Console.ReadLine();

        using (StreamWriter entryFile = new StreamWriter(filename))
        {
            entryFile.WriteLine(saveString);
            _entryList.Add(saveString);
        }
    }

    public void delete()
    {
        Console.WriteLine("Which entry would you like to delete? (please enter a number)");
        int entryNum = int.Parse(Console.ReadLine());

        _entryList.RemoveAt(entryNum);
    }
}