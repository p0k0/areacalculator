using System;
using System.Collections.Generic;

namespace calculator.primitive.implementation.factory.areacontext
{
    public class CircleAreaContext<TMeasure> : AreaContextBase<TMeasure>
    {
        public CircleAreaContext(TMeasure r)
        {
            this.Measure = new List<TMeasure>(1) {r};
        }
    }
}