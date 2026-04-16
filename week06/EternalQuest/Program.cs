using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager m = new GoalManager();
        string n = "talk";
        string d = "speak well and loud";
        int p = 55;
        m._goals.Add(new SimpleGoal(n,d,p));
        string nn = "sing";
        string dd = "sing a solo in church";
        int pp = 200;
        m._goals.Add(new SimpleGoal(nn,dd,pp));
        m.Start();
        
        /*m.ListGoalDetails();
        Console.WriteLine();
        for(int i=0; i<m._goals.Count; i++) 
        {   
            Console.WriteLine(m._goals[i].GetDetailsString());
        }
        for(int i=0; i<m._goals.Count; i++) 
        {
            Console.WriteLine(m._goals[i].GetStringRepresentation());
        }*/
        //m.SaveGoals();
    }
}