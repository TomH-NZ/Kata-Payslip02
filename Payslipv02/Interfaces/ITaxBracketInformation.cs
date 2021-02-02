
using System.Collections.Generic;

namespace Payslipv02.Interfaces
{
    public interface ITaxBracketInformation
    {
        public Dictionary<string, double> EighteenThousandTwoHundred { get; }
        public Dictionary<string, double> ThirtySevenThousand { get; }
        public Dictionary<string, double> EightySevenThousand { get; }
        public Dictionary<string, double> OneHundredEightyThousand { get; }
        public Dictionary<string, double> OverOneHundredEightyThousand { get; }
    }
}