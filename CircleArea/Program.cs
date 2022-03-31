using System;
using System.Collections.Generic;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFigure> figures = new List<IFigure>();
            figures.AddRange(new IFigure[]
            {
                new Triangle(3, 3, 3),
                new Triangle(3, 4, 5),
                new Triangle(10, 11, 12),
                new Circle(3),
                new Circle(10),
                new Circle(5)
            });

            foreach (var figure in figures)
            {
                System.Console.WriteLine(figure.CalculateArea());
            }
            System.Console.WriteLine((figures[0] as Triangle).IsRightTriangle());
        }
    }
}
