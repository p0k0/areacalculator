using System;
using System.Linq;

namespace calculator.primitive.visitors
{
    public class VisitorTheoremBackPythagorean : VisitorTheorem
    {
        public VisitorTheoremBackPythagorean(double tolerance = Double.Epsilon)
        {
            _isConfirmed = false;
            _tolerance = tolerance;
        }

        public bool IsConfirmed
        {
            get { return _isConfirmed; }
        }

        public override void Visit(Triangle t)
        {
            var side = new[] { t.A, t.B, t.C };
            var quads = side.Select(_ => _ * _).ToList();
            _isConfirmed = quads.Any(quad =>
                Math.Abs(quads.Except(new[] {quad}).Sum() - quad) <= _tolerance);
        }


        private bool _isConfirmed;
        private readonly double _tolerance;
    }
}