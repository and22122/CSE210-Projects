using System;
using System.Collections.Generic;

class Cart
{
    public List<Item> _items = new List<Item>();

    public void Display()
    {
        foreach (Item item in _items)
        {
            Item.Display($"");
        }
    }
    public void AddItem()
    {
        System.Console.Write("Enter Description: ");
        string desc = Console.ReadLine();

        System.Console.Write("Enter Price: ");
        float price = float.Parse(Console.ReadLine());

        System.Console.Write("Enter Count: ");
        int count = int.Parse(Console.ReadLine());

        Item newItem = new Item();
        newItem._desc = desc;
        newItem._price = price;
        newItem._count = count;

        _items.Add(newItem);
    }
    public void RemoveItem()
    {

    }
    public void DoesItemExist()
    {

    }
    public float GetTotal()
    {
        float total = 0;
        foreach (Item item in _items)
        {
            total += item._price * item._count;
        }

        return total;
    }
}