using System;

namespace calculator.primitive
{
    public class AreaComputeStrategyFactoryBase<TMeasure>
    {
        public virtual AreaComputeStrategyBase<TMeasure> CreateCircleComputeStrategy()
        {
            throw new NotImplementedException();
        }
        
        public virtual AreaComputeStrategyBase<TMeasure> CreateEllipseComputeStrategy()
        {
            throw new NotImplementedException();
        }
        
        public virtual AreaComputeStrategyBase<TMeasure> CreateTriangleComputeStrategy()
        {
            throw new NotImplementedException();
        }
    }
}