using System;
using System.Collections.Generic;

class Item
{
    public string _desc = "";
    public float _price = 0F;
    public int _count = 0;

    public void Display()
    {
        System.Console.WriteLine($"{_desc}, ${_price}, {_count}");
    }
}