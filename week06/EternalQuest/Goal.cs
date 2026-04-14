using System;

public class Goal
{
    string _shortHand;
    string _description;
    string _points;
    public Goal(string n, string d, string p)
    {
        _shortHand = n;
        _description = d;
        _points = p;
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