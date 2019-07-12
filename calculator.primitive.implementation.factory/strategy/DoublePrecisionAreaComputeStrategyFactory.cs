using calculator.compute.strategy;

namespace calculator.primitive.implementation.factory.strategy
{
    public class DoublePrecisionAreaComputeStrategyFactory : AreaComputeStrategyFactory<double>
    {
        public override AreaComputeStrategy<double> CreateCircleComputeStrategy()
        {
            return new CircleAreaComputeStrategy();
        }

        public override AreaComputeStrategy<double> CreateEllipseComputeStrategy()
        {
            return new EllipseAreaComputeStrategy();
        }

        public override AreaComputeStrategy<double> CreateTriangleComputeStrategy()
        {
            return new TriangleAreaComputeStrategy();
        }
    }
}