using System;

namespace calculator.primitive
{
    public class AreaComputeStrategy<TMeasure>
    {
        public virtual TMeasure ComputeCircleArea(AreaContextBase<TMeasure> areaContextBase)
        {
            throw new NotImplementedException();
        }
        
        public virtual TMeasure ComputeEllipseArea(AreaContextBase<TMeasure> areaContextBase)
        {
            throw new NotImplementedException();
        }
        
        public virtual TMeasure ComputeTriangleArea(AreaContextBase<TMeasure> areaContextBase)
        {
            throw new NotImplementedException();
        }
    }
}