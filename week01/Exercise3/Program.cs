using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);
            int number;
            int guesses = 0;
            string qty = "try";
            do
            {
                Console.Write("What is the magic number? ");
                number = int.Parse(Console.ReadLine());
                if (magicNumber > number)
                {
                    Console.WriteLine("Higher");
                }
                if (magicNumber < number)
                {
                    Console.WriteLine("Lower");
                }
                guesses++;
            }
            while (number != magicNumber);
            if (guesses > 1) qty = "tries";
            Console.WriteLine($"You got it in {guesses} {qty}!!");
            Console.Write("Would you like to play again? N to stop: ");
            playAgain = Console.ReadLine();
        }
        while (!playAgain.ToLower().Contains('n'));
    }
}