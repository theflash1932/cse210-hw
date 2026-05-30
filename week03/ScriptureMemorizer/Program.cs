// Extra: Program creates a List of words not yet hidden and selects from those words at 
// random to hide, ensuring each turn hides 3 new words.

using System;
using System.Net.Quic;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string input = "";
        string t = "But while he thought on these things, behold, the angel of the Lord appeared unto him in a dream, saying, Joseph, thou son of David, fear not to take unto thee Mary thy wife: for that which is conceived in her is of the Holy Ghost.";
        Reference r = new Reference("Matthew", 1, 20);
        Scripture s = new Scripture(r, t);
        do
        {
            Console.Clear();
            Console.WriteLine("\n");
            r.ShowReference();
            s.ShowReference();
            Console.WriteLine("\n");
            Console.WriteLine("Enter to continue, 'quit' to end");
            input = Console.ReadLine();
            if (s.AllHidden()) { s.Finish(); break; }
        }
        while (!input.ToLower().Contains("q"));
    }
}
