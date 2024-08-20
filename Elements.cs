namespace shur_excel {
    public class BasicElement
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

    public class Element : BasicElement
    {
        public double Value { get; }
        public Element(int numFrom, int numTo, double lowerBound, double upperBound, double value) : base(numFrom, numTo, lowerBound, upperBound)
        {
            Value = value;
        }
    }
}

