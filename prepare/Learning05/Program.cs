using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("yellow", 2);
        shapes.Add(s1);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The shape is the color {s.GetColor()} and its area is {s.GetArea()}");
        }
    }
}