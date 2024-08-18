using System.Collections.Generic;

namespace shur_excel;

class Element
{
    public int NumFrom { get; }
    public int NumTo { get; }
    public double LowerBound { get; }
    public double UpperBound { get; }

    public Element(int numFrom, int numTo, double lowerBound, double upperBound)
    {
        NumFrom = numFrom;
        NumTo = numTo;
        LowerBound = lowerBound;
        UpperBound = upperBound;
    }
}

