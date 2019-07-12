using calculator.compute.strategy;
using calculator.primitive.implementation.factory.areacontext;

namespace calculator.primitive.implementation.factory.figure
{
    public class CircleFigureFactory : FigureFactory<double>
    {
        public CircleFigureFactory()
        {
            _areaContextFactory = new CircleAreaContextFactory<double>();
            _areaComputeStrategyFactory = new DoublePrecisionAreaComputeStrategyFactory();
        }
        public override FigureBase<double> CreateCircle(double radius)
        {
            return new Circle<double>(
                _areaContextFactory.CreateCircleAreaContext(radius),
                _areaComputeStrategyFactory.CreateCircleComputeStrategy());
        }
    }
}