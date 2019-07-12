using System;

namespace calculator.primitive.implementation.factory.figure
{
    public class CircleFigureFactory<TMeasure> : FigureFactory<TMeasure>
    {
        public override FigureBase<TMeasure> CreateCircle(TMeasure radius)
        {
            return new Circle<TMeasure>();
        }
    }
}