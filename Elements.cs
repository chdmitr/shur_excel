namespace shur_excel;

public record BasicElement
{
    public int NumFrom { get; }
    public int NumTo { get; }
    public double LowerBound { get; }
    public double UpperBound { get; }

    public BasicElement(int numFrom, int numTo, double lowerBound, double upperBound)
    {
        NumFrom = numFrom;
        NumTo = numTo;
        LowerBound = lowerBound;
        UpperBound = upperBound;
    }
}

public record Element : BasicElement
{
    public double Value { get; init; }
    public Element(BasicElement original, double value) : base(original)
    {
        Value = value;
    }
}
