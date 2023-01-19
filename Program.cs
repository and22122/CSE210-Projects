using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Cart cart = new Cart();

        menu.Display();

        cart.AddItem();
        cart.AddItem();
        cart.Display();
        System.Console.WriteLine(cart.GetTotal());
    }
}