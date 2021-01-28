using System.Collections.Generic;

namespace Payslipv02.Tax
{
    public class TaxBrackets : ITaxBrackets
    {
        private readonly TaxBracketInformation _taxInfo = new TaxBracketInformation(); //Remove dependency using factory method.
        //private readonly ITaxBracketInformation _taxInfo = new TaxBracketInformation();
        
        public Dictionary<string, double> Calculate(double annualSalary)
        {
            if (annualSalary > 180000)
            {
                return _taxInfo.OverOneHundredEightyThousand;
            }
            
            if (annualSalary > 87000 && annualSalary <= 180000)
            {
                return _taxInfo.OneHundredEightyThousand;
            }
            
            if (annualSalary > 37000 && annualSalary <= 87000)
            {
                return _taxInfo.EightySevenThousand;
            }
            
            if (annualSalary > 18200 && annualSalary <= 37000)
            {
                return _taxInfo.ThirtySevenThousand;
            }

            return _taxInfo.EighteenThousandTwoHundred;
        }
    }
}