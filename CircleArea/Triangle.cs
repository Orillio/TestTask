using System;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;
using static System.Math;
namespace CircleArea
{
    public class Triangle : IFigure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        private double p => (A + B + C) / 2.0;

        public Triangle(int a, int b, int c){
            A = a;
            B = b;
            C = c;
        }
        public double CalculateArea() 
        {
            if(A + B < C || A + C < B || C + B < A)
            {
                throw new Exception("Triangle does not exist");
            }
            return Sqrt(p * (p - A) * (p - B) * (p - C));

        }
        public bool IsRightTriangle(){
            if(Pow(A, 2) + Pow(B, 2) == Pow(C, 2)
                || Pow(A, 2) + Pow(C, 2) == Pow(B, 2)
                || Pow(C, 2) + Pow(B, 2) == Pow(A, 2))
            {
                return true;
            }
            return false;
        }

    }
}