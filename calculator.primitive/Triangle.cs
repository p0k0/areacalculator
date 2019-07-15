using System;
using System.Linq;
using calculator.primitive.visitors;

namespace calculator.primitive
{
    public class Triangle : IFigure
    {
        public double A => _a;
        public double B => _b;
        public double C => _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        
        public double GetArea()
        {
            var p = (_a + _b + _c) / 2d;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public void Accept(VisitorTheorem visitorTheorem)
        {
            visitorTheorem.Visit(this);
        }
        
        private double _a;
        private double _b;
        private double _c;
    }
}