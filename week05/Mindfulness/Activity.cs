using System;

public class Activity
{
    string _activityName;
    int _stringIndex;
    List<string> _activityDesc = new List<string> {
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        };
    public int _duration = 0;
    
    public Activity(string s, int i)
    {
        _activityName = s;
        _stringIndex = i;
    }
    public void PromptDuration()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_activityDesc[_stringIndex]);
        Console.WriteLine("");
        Console.Write("How long would you like to do this activity for (in seconds)? ");
        if(int.TryParse(Console.ReadLine(), out _duration)) {}
    }
    public void PauseTime(string t, int sec)
    {
        Console.Write($"{t}... ");
        for(int i=sec; i>0; i--)
        {
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("\b \b");
    }
    public void CountTime(string t, int sec)
    {
        Console.Write($"{t}");
        double d = Math.Floor(((double)sec)/2);
        int m = (int) d;
        for(int i=0; i<5; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        for(int i=0; i<5; i++)
        {
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }
    public void PauseAnimation()
    {
        for(int i=0; i<10; i++)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
        }  
    }
}