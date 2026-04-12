using System;

public class Rectangle : Shape
{
    double _length;
    double _width;
    public Rectangle(double l, double w, string c)
        : base(c)
    {
        _length = l;
        _width = w;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}