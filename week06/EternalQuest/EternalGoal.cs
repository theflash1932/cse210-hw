using System;

public class EternalGoal : Goal
{

    public EternalGoal(string n, string d, int p)
        : base(n, d, p)
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
        int f = GetDetailsString().IndexOf('(');
        int g = f - 5;
        int h = GetDetailsString().IndexOf(')');
        int j = GetDetailsString().IndexOf(',');
        int k = GetDetailsString().Length;
        string gName = GetDetailsString().Substring(4, g);
        string gDesc = GetDetailsString().Substring((f + 1), (h - f - 1));
        string gPoints = GetDetailsString().Substring((j + 2), (k - j - 2));
        bool gComp = IsComplete();

        return $"{gName},{gDesc},{gPoints},{gComp}";
    }
}