using System;
using System.Collections.Generic;

public class Square:Shape
{
    double _side;
    public Square(string color, double side)
    {
        SetColor(color);
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}