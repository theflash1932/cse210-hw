using System;

public class Shape
{
    string _color;
    public Shape(string c)
    {
        _color = c;        
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string s)
    {
        _color = s;
    }
    public virtual double GetArea()
    {
        return 0;
    }
}
