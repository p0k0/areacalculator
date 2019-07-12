using System.Collections.Generic;

namespace calculator.primitive.implementation.factory.areacontext
{
    public class EllipseAreaContext<TMeasure> : AreaContextBase<TMeasure>
    {
        public EllipseAreaContext(TMeasure a, TMeasure b)
        {
            this.Measure = new List<TMeasure>(2){ a, b };
        }
    }
}