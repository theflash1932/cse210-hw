using System;
using System.Drawing;
using System.IO;

public class GoalManager
{
    List<Goal>_goals = new List<Goal> {};
    int _score;
    public GoalManager()
    {
        
    }
    public void Start()
    {
        
    }
    public void DisplayPlayerInfo()
    {
        
    }
    public void ListGoalNames()
    {
        
    }
    public void ListGoalDetails()
    {
        
    }
    public void CreateGoal()
    {
        
    }
    public void RecordEvent()
    {
        
    }
    public void SaveGoals()
    {
        string color = "blue";
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("This will be the first line in the file.");
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }
    public void LoadGoals()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}