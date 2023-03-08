using System;
using System.Collections.Generic;

public abstract class Shape
{
    string _color = "";

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}