using System;

namespace FigureCalculator.Entity
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetSquare() => Math.PI * Math.Pow(_radius, 2);
    }
}