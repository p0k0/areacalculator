using System;
using calculator.compute.strategy;
using calculator.primitive.implementation.factory.areacontext;

namespace calculator.primitive.implementation.factory.figure
{
    public class EllipseFactory: FigureFactory<double>
    {
        public EllipseFactory()
        {
            _areaContextFactory = new EllipseAreaContextFactory<double>();
            _areaComputeStrategyFactory = new DoublePrecisionAreaComputeStrategyFactory();
        }
        
        public override FigureBase<double> CreateEllipse(double a, double b)
        {
            return new Ellipse<double>(
                _areaContextFactory.CreateEllipseAreaContext(a, b),
                _areaComputeStrategyFactory.CreateEllipseComputeStrategy());
        }
    }
}