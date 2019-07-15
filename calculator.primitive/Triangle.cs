using System;
using System.Linq;

namespace calculator.primitive
{
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;

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

        public bool HasRightAngle(double tolerance)
        {
            var side = new[] {_a, _b, _c};
            var quads = side.Select(_ => _ * _).ToList();
            return quads.Any(quad => Math.Abs(quads.Except(new []{ quad }).Sum( s => s * s) - quad * quad) < tolerance );
        }
    }
}