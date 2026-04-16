using System;

public abstract class Goal
{
    string _shortHand;
    string _description;
    int _points;
    public Goal(string n, string d, int p)
    {
        _shortHand = n;
        _description = d;
        _points = p;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public string GetDetailsString()
    {
        bool c = IsComplete();
        string check;
        if(c) {check = "X";}
        else {check = " ";}
        return $"[{check}] {_shortHand} ({_description}), {_points}";
    }
    public abstract string GetStringRepresentation();
}