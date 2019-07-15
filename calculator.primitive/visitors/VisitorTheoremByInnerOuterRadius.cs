using System;
using System.Linq;

namespace calculator.primitive.visitors
{
    public class VisitorTheoremByInnerOuterRadius : VisitorTheorem
    {
        public VisitorTheoremByInnerOuterRadius(double tolerance = Double.Epsilon)
        {
            _isConfirmed = false;
            _tolerance = tolerance;
        }

        public bool IsConfirmed
        {
            get { return _isConfirmed; }
        }

        //a + b = 2 * (R + r)
        public override void Visit(Triangle t)
        {
            var p = (t.A + t.B + t.C) / 2d;
            _outerRadius = t.A * t.B * t.C / 
                           (4 * Math.Sqrt(p * (p - t.A) * (p - t.B) * (p - t.C)));
            _innerRadius = Math.Sqrt((p - t.A) * (p - t.B) * (p - t.C) / p);
            
            var side = new[] { t.A, t.B, t.C };
            var sum = side.Sum();
            var rhs = 2 * (_innerRadius + _outerRadius);
            if (side.Any(s => Math.Abs(sum - s - rhs) <= _tolerance))
            {
                _isConfirmed = true;
            }
        }

        private bool _isConfirmed;
        private double _outerRadius;
        private double _innerRadius;
        private readonly double _tolerance;
    }
}