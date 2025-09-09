using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
        List<int> numberList = new List<int>();
        int numEntry;
        do
        {
            Console.Write("Enter a number: ");
            numEntry = int.Parse(Console.ReadLine());
            numberList.Add(numEntry);
        }
        while (numEntry != 0);
        Console.WriteLine($"The sum is: {numberList.Sum()}");
        Console.WriteLine($"The average is: {numberList.Average()}");
        Console.WriteLine($"The largest number is: {numberList.Max()}");
        int small = 0;
        List<int> posNum = new List<int>();
        foreach (int num in numberList)
        {
            if (num > 0) posNum.Add(num);
        }
        small = posNum.Min();
        Console.WriteLine($"Smallest positive number: {small}");
        Console.WriteLine("The sorted list is:");
        numberList.Sort();
        foreach (int num in numberList)
        {
            Console.WriteLine(num);
        }
    }
}