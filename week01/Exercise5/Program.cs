using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(),PromptUserNumber());
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static String PromptUserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int i) {
        return i * i;
    }
    static void DisplayResult(String u, int i)
    {
        Console.WriteLine($"Hi {u}! The square of your favorite number is {SquareNumber(i)}");
    }
}