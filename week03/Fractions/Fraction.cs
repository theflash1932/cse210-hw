using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // constructors
    public Fraction() {
        SetTopNumber(1);
        SetBottomNumber(1);
    }
    public Fraction(int n) {
        SetTopNumber(n);
        SetBottomNumber(1);
    }public Fraction(int n, int m) {
        SetTopNumber(n);
        SetBottomNumber(m);
    }
    
    // getters/setters
    public int GetTopNumber() {
        return _top;
    }
    public int GetBottomNumber() {
        return _bottom;
    }
    public void SetTopNumber(int i)
    {
        _top = i;
    }
    public void SetBottomNumber(int i)
    {
        _bottom = i;
    }
    
    // methods
    public String GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double) _top / _bottom;
    }

}