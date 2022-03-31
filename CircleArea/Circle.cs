using System;

namespace CircleArea
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }
        public Circle(double r) => Radius = r;
        public double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
    }
}