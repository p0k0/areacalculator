using System.Collections.Generic;

namespace calculator.primitive.implementation.factory.areacontext
{
    public class TriangleAreaContext<TMeasure> : AreaContextBase<TMeasure>
    {
        public TriangleAreaContext(TMeasure a, TMeasure b, TMeasure c)
        {
            this.Measure = new List<TMeasure>(3){ a, b, c };
        }
    }
}