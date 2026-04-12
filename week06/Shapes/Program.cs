using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape> {};
        shapes.Add(new Square(5,"White"));
        shapes.Add(new Rectangle(8,12,"Blue"));
        shapes.Add(new Circle(10,"Pink"));
        for(int i=0; i<shapes.Count(); i++)
        {
            Console.Write($"{shapes[i].GetColor()} ");
            Console.WriteLine(shapes[i].GetType());
            Console.WriteLine($"Area: {shapes[i].GetArea()}\n");
        }
    }
}