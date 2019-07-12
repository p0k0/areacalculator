using System;
using System.Linq;
using calculator.primitive;

namespace calculator.compute.strategy
{
    public class EllipseAreaComputeStrategy : AreaComputeStrategyBase<double>
    {
        public override double ComputeEllipseArea(AreaContextBase<double> areaContextBase)
        {
            return areaContextBase.Measure[0] * areaContextBase.Measure[1] * Math.PI;
        }
    }
}
