using System;

public class ListingActivity : Activity
{
    List<string> _prompts = new List<string> 
    {
        "Who are people that you appreciate? ",
        "What are personal strengths of yours? ",
        "Who are people that you have helped this week? ",
        "When have you felt the Holy Ghost this month? ",
        "Who are some of your personal heroes? "
    };
    public ListingActivity()
        : base("Listing", 2)
    {
        
    }
    public void RunClock()
    {
        Console.Clear();
        Random pIndex = new Random();
        int pPrompt = pIndex.Next(0,5);
        PauseTime(_prompts[pPrompt],9);
        int iCount = 0;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        do {
            Console.ReadLine();
            iCount++;
            DateTime currentTime = DateTime.Now;
            if(currentTime > futureTime)
            {
                _duration = 0;
            }
        }
        while (_duration > 0);
        Console.WriteLine($"\n{iCount} items! Well done on the listing activity!\n");
    }
}