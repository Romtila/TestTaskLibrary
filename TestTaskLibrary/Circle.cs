using System;

namespace TestTaskLibrary
{
    public class Circle : IFigure
    {
        public int Radius { get; private set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public Circle(Circle circle)
        {
            Radius = circle.Radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }

    public  class Rectangle : IFigure
    {
        public Rectangle(int b, int a)
        {
            B = b;
            A = a;
        }

        public int A { get; private set; }

        public int B { get; private set; }

        public double CalculateSquare()
        {
            return this.A * this.B;
        }
    }
}