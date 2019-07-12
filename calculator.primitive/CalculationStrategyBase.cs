namespace calculator.primitive
{
    public abstract class CalculationStrategyBase<MeasureType>
    {
        public abstract MeasureType Calculate(AreaContextBase<MeasureType> areaContextBase);
    }
}