﻿using System;

namespace TestTaskLibrary
{
    public class Circle : IFigure<Circle>
    {
        public int Radius { get; set; }

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

        public double CalculateSquare(Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }

        public double CalculateSquare(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}