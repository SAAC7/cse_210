using System;
using System.Reflection.Metadata.Ecma335;

class Rectangle : Shape
{
    private double _length,_width;

    public Rectangle(string color,double length,double width) : base(color)
    {
        _length=length;
        _width=width;
    }
    public override double GetArea()
    {
        return _length*_width;
    }
}