using calculator.compute.strategy;
using calculator.primitive.implementation.factory.areacontext;
using calculator.primitive.implementation.factory.strategy;

namespace calculator.primitive.implementation.factory.figure
{
    public class TriangleFactory : FigureFactory<double>
    {
        public TriangleFactory()
        {
            _areaContextFactory = new TriangleAreaContextFactory<double>();
            _areaComputeStrategyFactory = new DoublePrecisionAreaComputeStrategyFactory();
        }
        
        public override FigureBase<double> CreateTriangle(double a, double b, double c)
        {
            return new Triangle<double>(
                _areaContextFactory.CreateTriangleAreaContext(a, b, c),
                _areaComputeStrategyFactory.CreateTriangleComputeStrategy());
        }
    }
}