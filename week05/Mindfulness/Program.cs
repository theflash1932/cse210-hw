using System;
using System.Diagnostics;

// member variables private by default
// EXTRA: total activities counted
// EXTRA: Breathe count indicated by a space move right for in, then left for out

class Program
{
    static void Main(string[] args)
    {
        int totalActivities = 0;
        string choice;
        Console.Clear();
        Console.WriteLine("Hello World! This is the Mindfulness Project.\n");
        do {
            Console.WriteLine("Menu\n----");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine($"\n{totalActivities} activities performed today.\n");
            choice = Console.ReadLine();
            if(choice is "1") 
            {
                BreathingActivity a = new BreathingActivity();
                a.PromptDuration();
                a.RunClock();
                totalActivities++;
            }
            if(choice is "2") 
            {
                ReflectionActivity a = new ReflectionActivity();
                a.PromptDuration();
                a.RunClock();
                totalActivities++;
            }
            if(choice is "3") {
                ListingActivity a = new ListingActivity();
                a.PromptDuration();
                a.RunClock();
                totalActivities++;
            }
        }
        while (choice is not "4");
        Console.WriteLine($"Congratulations on {totalActivities} mindfulness activities today. Come again soon!");
    }
}