using System;
using System.Linq;

namespace FigureCalculator.Entity
{
    public class Triangle : IFigure
    {
        private double[] _sides;

        public Triangle(double a,double b,double c)
        {
            _sides = new [] { a, b, c };
        }

        public double GetSquare()
        {
            var p = GetSemiPerimeter();
            double result = 0;
            //По формуле Герона
            foreach (double side in _sides)
            {
                result += p - side;
            }
            return Math.Sqrt(p * result);
        }
        private double GetSemiPerimeter() => _sides.Sum()/2;
    }
}