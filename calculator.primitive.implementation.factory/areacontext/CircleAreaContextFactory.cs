using System;
using calculator.primitive.implementation.factory.areacontext;

namespace calculator.primitive.implementation.factory
{
    public class CircleAreaContextFactory<TMeasure> : AreaContextFactory<TMeasure>
    {
        public override AreaContextBase<TMeasure> CreateCircleAreaContext(TMeasure radius)
        {
            return new CircleAreaContext<TMeasure>(radius);
        }
    }
}
