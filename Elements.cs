using System.Collections.Generic;

namespace shur_excel;

public class Element
{
    public int NumFrom { get; }
    public int NumTo { get; }
    public double LowerBound { get; }
    public double UpperBound { get; }
    public double Value { get; set; }

    public Element(int numFrom, int numTo, double lowerBound, double upperBound, double value = 0.0)
    {
        NumFrom = numFrom;
        NumTo = numTo;
        LowerBound = lowerBound;
        UpperBound = upperBound;
        Value = value;
    }

    public Element Clone()
    {
        return new Element(NumFrom, NumTo, LowerBound, UpperBound, Value);
    }
}

