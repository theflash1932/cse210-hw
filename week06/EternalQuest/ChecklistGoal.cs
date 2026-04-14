using System;

public class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;
    public ChecklistGoal(string n, string d, string p, int t, int b)
        : base(n,d,p)
    {
        _target = t;
        _bonus = b;

    }
    public void RecordEvent()
    {
        
    }
    public bool IsComplete()
    {
        return false;
    }
    public string GetDetailsString()
    {
        return "";
    }
    public string GetStringRepresenation()
    {
        return "";
    }
}