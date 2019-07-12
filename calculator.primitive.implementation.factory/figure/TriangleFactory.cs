using System;

namespace calculator.primitive.implementation.factory.figure
{
    public class EllipseFactory<TMeasure> : FigureFactory<TMeasure>
    {
        public override FigureBase<TMeasure> CreateCircle(TMeasure radius)
        {
            return new Ellipse<TMeasure>();
        }
    }
}