using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void displayEntries()
    {
        foreach (Entry e in _entries)
        {
            e.writeEntry();
        }
    }

    public void saveEntries()
    {
        Console.Write("What file do you want to save to?");

        string filename = Console.ReadLine();

        using (StreamWriter saveFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries) {
                saveFile.WriteLine(e.getText());
            }
        }
    }

    public void addEntry(Entry inpEntry)
    {
        _entries.Add(inpEntry);
    }

    public void loadEntries()
    {
        Console.Write("What file do you want to load from?");

        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _entries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string dt = parts[0];
            string p = parts[1];
            string r = parts[2];

            Entry e = new Entry();
            e._dateString = dt;
            e._prompt = p;
            e._response = r;

            _entries.Add(e);
        }
    }
}