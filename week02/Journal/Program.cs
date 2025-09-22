using System;
using System.IO.Enumeration;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

// ***************** Exceeding requirements: ****************
// Option to save as json for export to web / other services.
// **********************************************************

class Program
{
    static void Main(string[] args)
    {
        Journal j = new Journal();
        string choice = "";
        string journalLocation = ""; // = "myjournal.txt";
        string filename = $"..\\..\\..\\{journalLocation}"; // = $"..\\..\\..\\{journalLocation}";
        do
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1 - Load a journal");
            Console.WriteLine("2 - Display journal");
            Console.WriteLine("3 - Write a new entry");
            Console.WriteLine("4 - Save journal");
            Console.WriteLine("5 - Exit (no save)");
            Console.WriteLine("6 - Save as JSON");
            Console.Write("Choice: ");
            choice = Console.ReadLine();
            if (int.Parse(choice) == 1)
            {
                Console.Write("Journal file to load: ");
                journalLocation = Console.ReadLine();
                filename = $"..\\..\\..\\{journalLocation}";
                j.LoadFromFile(filename);
            }
            if (int.Parse(choice) == 2)
            {
                foreach (Entry e in j._entries)
                {
                    j.DisplayEntries(e);
                }
            }
            if (int.Parse(choice) == 3)
            {
                string a = DateTime.Now.ToString();
                string b = new PromptGenerator().GetRandomPrompt();
                Console.WriteLine(b);
                Console.WriteLine("Write your entry: ");
                string c = Console.ReadLine();
                j.AddEntry(new Entry(a, b, c));
            }
            if (int.Parse(choice) == 4)
            {
                j.SaveToFile(filename);
            }
            if (int.Parse(choice) == 6)
            {
                j.SaveAsJSON(filename);
            }
        }
        while (int.Parse(choice) != 5);
        Console.WriteLine("Thank you, come back soon!");
    }
}





