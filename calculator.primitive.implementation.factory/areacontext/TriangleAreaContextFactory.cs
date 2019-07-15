using calculator.primitive.implementation.areacontext;

namespace calculator.primitive.implementation.factory.areacontext
{
    public class TriangleAreaContextFactory<TMeasure> : AreaContextFactory<TMeasure>
    {
        public override AreaContextBase<TMeasure> CreateTriangleAreaContext(TMeasure a, TMeasure b, TMeasure c)
        {
            return new TriangleAreaContext<TMeasure>(a, b, c);
        }
    }
}
