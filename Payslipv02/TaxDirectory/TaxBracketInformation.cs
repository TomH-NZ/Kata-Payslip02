using System.Collections.Generic;
using Payslipv02.Interfaces;

namespace Payslipv02.TaxDirectory
{
    public class TaxBracketInformation : ITaxBracketInformation
    {
        public readonly Dictionary<string, double> EighteenThousandTwoHundred = new Dictionary<string, double>
       {
           {"UpperBracketLimit", 18200},
           {"LowerBracketLimit", 0},
           {"TaxPercent", 0},
           {"PreviousBracketTaxTotal", 0}
       };
       
       public readonly Dictionary<string, double> ThirtySevenThousand = new Dictionary<string, double>
       {
           {"UpperBracketLimit", 37000},
           {"LowerBracketLimit", 18201},
           {"TaxPercent", 19},
           {"PreviousBracketTaxTotal", 0}
       };
       
       public readonly Dictionary<string, double> EightySevenThousand = new Dictionary<string, double>
       {
           {"UpperBracketLimit", 87000},
           {"LowerBracketLimit", 37001},
           {"TaxPercent", 32.5},
           {"PreviousBracketTaxTotal", 3572}
       };
       
       public readonly Dictionary<string, double> OneHundredEightyThousand = new Dictionary<string, double>
       {
           {"UpperBracketLimit", 180000},
           {"LowerBracketLimit", 87001},
           {"TaxPercent", 37},
           {"PreviousBracketTaxTotal", 19822}
       };
       
       public readonly Dictionary<string, double> OverOneHundredEightyThousand = new Dictionary<string, double>
       {
           {"UpperBracketLimit", 180001},
           {"LowerBracketLimit", 180001},
           {"TaxPercent", 45},
           {"PreviousBracketTaxTotal", 54232}
       };
    }
}