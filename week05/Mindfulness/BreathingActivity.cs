using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", 0)
    {
        
    }
    public void RunClock()
    {
        Console.Clear();
        PauseTime("Get ready",5);
        do {
            CountTime("Breathe ",5);
            //CountTime("Breathe out",5);
            _duration -= 5;
            Console.WriteLine();
        }
        while (_duration > 0);
        Console.WriteLine("\nWell done on the breathing activity!\n");
    }
}