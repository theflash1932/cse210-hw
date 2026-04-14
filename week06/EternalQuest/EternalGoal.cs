using System;

public class EternalGoal : Goal
{
    
    public EternalGoal(string n, string d, string p)
        : base(n,d,p)
    {
        
    }
    public void RecordEvent()
    {
        
    }
    public bool IsComplete()
    {
        return false;
    }
    public string GetStringRepresenation()
    {
        return "";
    }
}