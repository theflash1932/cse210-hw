using System;

public class SimpleGoal : Goal
{
    bool _isComplete;
    public SimpleGoal(string n, string d, string p)
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