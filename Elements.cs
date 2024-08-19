namespace shur_excel;

public record BasicElement(int NumFrom, int NumTo, double LowerBound, double UpperBound);
public record Element : BasicElement
{
    public double Value { get; init; }
    public Element(BasicElement original, double value) : base(original)
    {
        Value = value;
    }
}
