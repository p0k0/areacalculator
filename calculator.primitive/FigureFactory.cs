using System;

namespace calculator.primitive
{
    public class FigureFactory<TMeasure>
    {
        protected AreaContextFactory<TMeasure> _areaContextFactory;
        protected AreaComputeStrategyFactory<TMeasure> _areaComputeStrategyFactory;
        
        public virtual FigureBase<TMeasure> CreateCircle(TMeasure radius)
        {
            throw new NotImplementedException();
        }
        
        public virtual FigureBase<TMeasure> CreateEllipse(TMeasure a, TMeasure b)
        {
            throw new NotImplementedException();
        }
        
        public virtual FigureBase<TMeasure> CreateTriangle(TMeasure a, TMeasure b, TMeasure c)
        {
            throw new NotImplementedException();
        }
    }
}