using System;
using System.Linq;
using calculator.primitive;

namespace calculator.compute.strategy
{
    public class TriangleAreaComputeStrategy : AreaComputeStrategyBase<double>
    {
        public override double ComputeTriangleArea(AreaContextBase<double> areaContextBase)
        {
            var a = areaContextBase.Measure[0];
            var b = areaContextBase.Measure[1];
            var c = areaContextBase.Measure[2];
            var p = areaContextBase.Measure.AsEnumerable().Sum() / 2d;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
