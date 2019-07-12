using System;

namespace calculator.primitive.implementation
{
    public class Circle<TMeasure> : FigureBase<TMeasure>
    {
        private readonly AreaContextBase<TMeasure> _areaContext;
        private readonly AreaComputeStrategyBase<TMeasure> _areaComputeStrategy;

        public Circle(AreaContextBase<TMeasure> areaContext, AreaComputeStrategyBase<TMeasure> areaComputeStrategy)
        {
            _areaContext = areaContext;
            _areaComputeStrategy = areaComputeStrategy;
        }
        
        public override TMeasure GetArea()
        {
            return _areaComputeStrategy.ComputeCircleArea(_areaContext);
        }
    }
}
