using System;

public class EternalGoal : Goal
{
    
    public EternalGoal(string n, string d, int p)
        : base(n,d,p)
    {
        
    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}