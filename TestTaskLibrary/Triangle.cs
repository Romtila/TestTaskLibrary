using System;

namespace TestTaskLibrary
{
    public class Triangle : IFigure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

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