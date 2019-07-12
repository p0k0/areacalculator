namespace calculator.primitive
{
    public abstract class AreaComputeStrategyBase<TMeasure>
    {
        public abstract TMeasure Compute(AreaContextBase<TMeasure> areaContextBase);
    }
}