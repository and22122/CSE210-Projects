using System;
using System.Collections.Generic;

public class entry
{
    string _date = DateTime.toString();
    string _text = "";

    public string GetVariables()
    {
        return _date + " " + _text;
    }
}