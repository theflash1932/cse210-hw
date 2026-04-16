using System;

public class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;
    public ChecklistGoal(string n, string d, int p, int t, int b)
        : base(n,d,p)
    {
        _target = t;
        _bonus = b;

    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false;
    }
    //public string GetDetailsString()
    //{
    //    return "";
    //}
    public override string GetStringRepresentation()
    {
        return $"{_amountCompleted},{_target},{_bonus}";
    }
}