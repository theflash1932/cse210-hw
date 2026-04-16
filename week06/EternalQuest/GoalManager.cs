using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;

public class GoalManager
{
    public List<Goal>_goals = new List<Goal> {};
    int _score;
    public GoalManager()
    {
        
    }
    public void Start()
    {
        string input = "6";
        int choice = 6;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Create new goal");
            Console.WriteLine("2 - List goals");
            Console.WriteLine("3 - Save goals");
            Console.WriteLine("4 - Load goals");
            Console.WriteLine("5 - Record event");
            Console.WriteLine("6 - Quit\n");
            ListGoalDetails();
            input = Console.ReadLine();
            choice = int.Parse(input);
            if(choice == 1) {CreateGoal();}
            else if(choice == 2)
            {
                ListGoalDetails();
            }
            else if(choice == 3) 
            {
                SaveGoals();
            }
            else if(choice == 4) {LoadGoals();}
            else if(choice == 5) {RecordEvent();}
            else if(choice == 6) {Console.WriteLine("Done? Ok, come back soon!"); break;}
        }
        while (choice != 6);
    }
    public void DisplayPlayerInfo()
    {
        
    }
    public void ListGoalNames()
    {
        
    }
    public void ListGoalDetails()
    {
        int countInc = 0;
        for(int i=0; i<_goals.Count; i++)
        {
            countInc++;
            Console.WriteLine($"{countInc} {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        string input = "4";
        int choice = 4;
        int warn = 0;
        do
        {
            Console.Clear();
            if(warn == 1) {Console.WriteLine("*Options are 1-6");}
            Console.WriteLine("Goal Types:");
            Console.WriteLine("1 - Simple goal");
            Console.WriteLine("2 - Eternal goals");
            Console.WriteLine("3 - Checklist goals");
            Console.WriteLine("4 - Quit");
            Console.Write("What kind of goal would you like to create?");
            input = Console.ReadLine();
            bool poss = int.TryParse(input, out choice);
            warn = 0;
            if (poss) {choice = int.Parse(input);};
            if(choice == 1)
            {
                Console.Write("What is the name of your goal?");
                string n = Console.ReadLine();
                Console.Write("What is a short description of your goal?");
                string d = Console.ReadLine();
                Console.Write("Points for this goal?");
                string pp = Console.ReadLine();
                int p = int.Parse(pp);
                _goals.Add(new SimpleGoal(n,d,p));
            }
            else if(choice == 2) 
            {
                Console.Write("What is the name of your goal?");
                string n = Console.ReadLine();
                Console.Write("What is a short description of your goal?");
                string d = Console.ReadLine();
                Console.Write("Points for this goal?");
                string pp = Console.ReadLine();
                int p = int.Parse(pp);
                _goals.Add(new EternalGoal(n,d,p));                
            }
            else if(choice == 3)
            {
                Console.Write("What is the name of your goal?");
                string n = Console.ReadLine();
                Console.Write("What is a short description of your goal?");
                string d = Console.ReadLine();
                Console.Write("Points for this goal?");
                string pp = Console.ReadLine();
                int p = int.Parse(pp);
                Console.Write("How many times for a bonus?");
                string t = Console.ReadLine();
                int tt = int.Parse(t);
                Console.Write("Bonus amount?");
                string b = Console.ReadLine();
                _goals.Add(new ChecklistGoal(n,d,p,int.Parse(t),int.Parse(b))); 
            }
            else if(choice == 4) {Console.WriteLine("Excellent!"); break;}
            else {warn = 1;}
        }
        while (choice != 6);
    }
    public void RecordEvent()
    {
        
    }
    public void SaveGoals()
    {
        string filename = "myFile.txt";
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            for (int i=0; i<_goals.Count; i++)
            {
                outputFile.WriteLine($"{_goals.GetType()},{_goals[i].GetStringRepresentation()}");   
            }
        }
    }
    public void LoadGoals()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            int pEnd = parts.Length;
            for(int i=0; i<pEnd; i++)
            {
                string goalType = parts[0];
                string shortHand = parts[1];
                string description = parts[2];
                string points = parts[3];
                string complete = parts[4];
                // ChecklistGoals
                string percComp;
                string target;
                string bonus;
                if(i<pEnd) { percComp = parts[5]; }
                if(i<pEnd) { target = parts[6]; }
                if(i<pEnd) { bonus = parts[7]; }
            }

            
            Console.WriteLine($"{_shortHand} {_description}");
        }
    }
}

    int _amountCompleted;
    int _target;
    int _bonus;