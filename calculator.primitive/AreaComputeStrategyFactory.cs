using System;

namespace calculator.primitive
{
    public class AreaComputeStrategyFactory<TMeasure>
    {
        public virtual AreaComputeStrategy<TMeasure> CreateCircleComputeStrategy()
        {
            throw new NotImplementedException();
        }
        
        public virtual AreaComputeStrategy<TMeasure> CreateEllipseComputeStrategy()
        {
            throw new NotImplementedException();
        }
        
        public virtual AreaComputeStrategy<TMeasure> CreateTriangleComputeStrategy()
        {
            throw new NotImplementedException();
        }
    }
}