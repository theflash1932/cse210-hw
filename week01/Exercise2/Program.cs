using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);
        string letterGrade;
        string qualifier = "";

        // Determine letter grade based on percentage
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else letterGrade = "F";

        // Determine + / - for grade qualifier
        if (grade >= 60 && grade < 97)
        {
            if (grade % 10 >= 7)
            {
                qualifier = "+";
            }
            if (grade % 10 < 3)
            {
                qualifier = "-";
            }
        }
        Console.WriteLine($"Your letter grade: {letterGrade}{qualifier}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
            Console.WriteLine("Sorry, you didn't pass. Better luck next time!");

    }
}