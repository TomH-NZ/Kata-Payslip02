using System;
using System.Collections.Generic;
using static Payslipv02.TaxBracketInformation;

namespace Payslipv02
{
    public class TaxBrackets : ITaxBrackets
    {
        public Dictionary<string, double> Calculate(double annualSalary)
        {
            if (annualSalary > 180000)
            {
                return OverOneHundredEightyThousand;
            }
            
            if (annualSalary > 87000 && annualSalary <= 180000)
            {
                return OverOneHundredEightyThousand;
            }
            
            if (annualSalary > 37000 && annualSalary <= 87000)
            {
                return EightySevenThousand;
            }
            
            if (annualSalary > 18200 && annualSalary <= 37000)
            {
                return ThirtySevenThousand;
            }

            return EighteenThousandTwoHundred;
        }
    }
}