using System;
using calculator.primitive.implementation.factory.areacontext;

namespace calculator.primitive.implementation.factory
{
    public class EllipseAreaContextFactory<TMeasure> : AreaContextFactory<TMeasure>
    {
        public override AreaContextBase<TMeasure> CreateEllipseAreaContext(TMeasure a, TMeasure b)
        {
            return new EllipseAreaContext<TMeasure>(a, b);
        }
    }
}
