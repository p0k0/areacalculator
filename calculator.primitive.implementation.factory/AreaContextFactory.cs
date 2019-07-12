using System;

namespace calculator.primitive.implementation.factory
{
    public abstract class AreaContextFactory<TMeasure>
    {
        public virtual AreaContextBase<TMeasure> CreateCircleAreaContext(TMeasure radius)
        {
            throw new NotImplementedException();
        }
        
        public virtual AreaContextBase<TMeasure> CreateEllipseAreaContext(TMeasure a, TMeasure b)
        {
            throw new NotImplementedException();
        }
        
        public virtual AreaContextBase<TMeasure> CreateTriangleAreaContext(TMeasure a, TMeasure b, TMeasure c)
        {
            throw new NotImplementedException();
        }
    }
}
