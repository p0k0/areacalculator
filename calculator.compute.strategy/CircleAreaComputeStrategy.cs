using System;
using System.Linq;
using calculator.primitive;

namespace calculator.compute.strategy
{
    public class CircleAreaComputeStrategy : AreaComputeStrategy<double>
    {
        public override double ComputeCircleArea(AreaContextBase<double> areaContextBase)
        {
            return areaContextBase.Measure[0] * areaContextBase.Measure[0] * Math.PI;
        }
    }
}
