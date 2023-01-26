using System;
using System.Collections.Generic;
using System.IO;

public class data
{
    List<string> _entryList = new List<string>();

    public void getEntries()
    {

    }

    public void Load()
    {

    }
    
    public void Save()
    {
        Console.Write("What file do you want to save to?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
        }
    }

    public void delete()
    {

    }
}