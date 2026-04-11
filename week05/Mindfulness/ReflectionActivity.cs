using System;

public class ReflectionActivity : Activity
{
    List<string> _prompts = new List<string> 
    {
        "Think of a time when you stood up for someone else ",
        "Think of a time when you did something really difficult ",
        "Think of a time when you helped someone in need ",
        "Think of a time when you did something truly selfless "
    };
    List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
        : base("Reflection", 1)
    {
        
    }
    public void RunClock()
    {
        Console.Clear();
        Random pIndex = new Random();
        int pPrompt = pIndex.Next(0, 4);
        PauseTime(_prompts[pPrompt],9);
        do {
            Random qIndex = new Random();
            int qPrompt = qIndex.Next(0, 9);
            Console.WriteLine();
            Console.WriteLine(_questions[qPrompt]);
            PauseAnimation();
            _duration -= 10;
        }
        while (_duration > 0);
        Console.WriteLine("\nWell done on the reflection activity!\n");
    }
}