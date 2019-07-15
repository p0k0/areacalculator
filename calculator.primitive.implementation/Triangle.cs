using System.Linq;
using calculator.primitive.implementation.areacontext;

namespace calculator.primitive.implementation
{
    public class Triangle<TMeasure> : FigureBase<TMeasure>
    {
        private readonly AreaContextBase<TMeasure> _areaContext;
        private readonly AreaComputeStrategy<TMeasure> _areaComputeStrategy;

        public Triangle(AreaContextBase<TMeasure> areaContext, AreaComputeStrategy<TMeasure> areaComputeStrategy)
        {
            _areaContext = areaContext;
            _areaComputeStrategy = areaComputeStrategy;
        }
        
        public override TMeasure GetArea()
        {
            return _areaComputeStrategy.ComputeTriangleArea(_areaContext);
        }

        public bool HasRightAngle()
        {
            var areaContext = _areaContext as TriangleAreaContext<double>;
            return areaContext.Measure.ToList().Any(side => 
                areaContext.Measure.Where(otherSide => otherSide != side)
                    .Aggregate(0d, (acc, val) => acc += (val * val)) == side * side );
        }
    }
}