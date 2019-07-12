namespace calculator.primitive
{
    public abstract class AreaContextBase<MeasureType>
    {
        public IList<MeasureType> Measure { get; set; }
    }
}