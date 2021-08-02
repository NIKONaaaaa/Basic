﻿namespace Shapes
{
    using System;
    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get => radius;
            private set => radius = value;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);

        public override double CalculatePerimeter() => 2 * Math.PI * Radius;

        public override string Draw() => base.Draw() + GetType().Name;
    }
}