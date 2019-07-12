using calculator.primitive;

namespace calculator.compute.strategy
{
    public class DoublePrecisionAreaComputeStrategyFactory : AreaComputeStrategyFactoryBase<double>
    {
        public override AreaComputeStrategyBase<double> CreateCircleComputeStrategy()
        {
            return new CircleAreaComputeStrategy();
        }

        public override AreaComputeStrategyBase<double> CreateEllipseComputeStrategy()
        {
            return new EllipseAreaComputeStrategy();
        }

        public override AreaComputeStrategyBase<double> CreateTriangleComputeStrategy()
        {
            return new TriangleAreaComputeStrategy();
        }
    }
}