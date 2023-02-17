using System;
using System.Collections.Generic;

public class Entry
{
    public string _prompt = "Feel free to write about something.";
    public string _response = "";
    public string _dateString = "";

    public void writeEntry()
    {
        Console.WriteLine(_dateString);
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
    }

    public string getText()
    {
        return $"{_dateString}|{_prompt}|{_response}";
    }
}