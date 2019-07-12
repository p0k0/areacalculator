namespace calculator.primitive.implementation.factory.areacontext
{
    public class EllipseAreaContextFactory<TMeasure> : AreaContextFactory<TMeasure>
    {
        public override AreaContextBase<TMeasure> CreateEllipseAreaContext(TMeasure a, TMeasure b)
        {
            return new EllipseAreaContext<TMeasure>(a, b);
        }
    }
}
