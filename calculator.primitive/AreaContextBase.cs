using System.Collections.Generic;

namespace calculator.primitive
{
    public abstract class AreaContextBase<TMeasure>
    {
        public IList<TMeasure> Measure { get; set; }
    }
}