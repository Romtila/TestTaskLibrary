using System;

namespace TestTaskLibrary
{
    public class Triangle : IFigure
    {

        public int A { get; private set; }
        public int B { get; private set; }
        public int C { get; private set; }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Triangle(Triangle triangle)
        {
            A = triangle.A;
            B = triangle.B;
            C = triangle.C;
        }

        public double CalculateSquare()
        {
            var p = (this.A + this.B + this.C) / 2;

            var s = Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));

            return s;
        }

        public bool SquarenessCheck(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }
    }
}