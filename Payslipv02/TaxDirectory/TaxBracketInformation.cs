using System.Collections.Generic;
using Payslipv02.FactoryDirectory;
using Payslipv02.Interfaces;

namespace Payslipv02.TaxDirectory
{
    public class TaxBracketInformation : ITaxBracketInformation
    {
        private static readonly INumberVariables PayslipCalculationVariables = Factory.NewPayslipCalculationVariables();
        
        public Dictionary<string, double> ThirtySevenThousand { get; } = new Dictionary<string, double>
       {
           {"UpperBracketLimit", PayslipCalculationVariables.ThirtySevenThousand},
           {"LowerBracketLimit", 18201},
           {"TaxPercent", 19}, // ToDo: Tax percent value
           {"PreviousBracketTaxTotal", 0}
       };
       
       public Dictionary<string, double> EightySevenThousand { get; } = new Dictionary<string, double>
       {
           {"UpperBracketLimit", PayslipCalculationVariables.EightySevenThousand},
           {"LowerBracketLimit", 37001},
           {"TaxPercent", 32.5},//ToDo: Tax percent value
           {"PreviousBracketTaxTotal", 3572}
       };
       
       public Dictionary<string, double> OneHundredEightyThousand { get; } = new Dictionary<string, double>
       {
           {"UpperBracketLimit", PayslipCalculationVariables.OneHundredEightyThousand},
           {"LowerBracketLimit", 87001},
           {"TaxPercent", 37}, //ToDo: Tax percent value
           {"PreviousBracketTaxTotal", 19822}
       };
       
       public Dictionary<string, double> OverOneHundredEightyThousand { get; } = new Dictionary<string, double>
       {
           {"UpperBracketLimit", 180001},
           {"LowerBracketLimit", 180001},
           {"TaxPercent", 45}, //ToDo: Tax percent value
           {"PreviousBracketTaxTotal", 54232}
       };

       public Dictionary<string, double> EighteenThousandTwoHundred { get; } = new Dictionary<string, double>
       {
           {"UpperBracketLimit", PayslipCalculationVariables.EighteenThousandTwoHundred},
           {"LowerBracketLimit", 0},
           {"TaxPercent", 0}, //ToDo: Tax percent value
           {"PreviousBracketTaxTotal", 0}
       };
    }
}