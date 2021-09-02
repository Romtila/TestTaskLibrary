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
}