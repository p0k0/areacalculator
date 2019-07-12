namespace calculator.primitive
{
    public abstract class CalculationStrategyBase<TMeasure>
    {
        public abstract TMeasure Calculate(AreaContextBase<TMeasure> areaContextBase);
    }
}