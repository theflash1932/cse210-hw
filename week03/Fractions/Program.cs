using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Fractions Project oh my.");
        //test constructors
        Fraction f1 = new Fraction();
        Console.WriteLine("Default constructor: " + f1.GetFractionString());
        Console.WriteLine("Default constructor: " + f1.GetDecimalValue());
        Fraction f2 = new Fraction(5);
        Console.WriteLine("One parameter: " + f2.GetFractionString());
        Console.WriteLine("One parameter: " + f2.GetDecimalValue());
        Fraction f3 = new Fraction(3,4);
        Console.WriteLine("Two parameter: " + f3.GetFractionString());
        Console.WriteLine("Two parameter: " + f3.GetDecimalValue());
        Fraction f4 = new Fraction(1,3);
        Console.WriteLine("Two parameter: " + f4.GetFractionString());
        Console.WriteLine("Two parameter: " + f4.GetDecimalValue());
        //test output formats
    }

}
