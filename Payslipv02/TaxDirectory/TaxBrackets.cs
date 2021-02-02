using System.Collections.Generic;
using Payslipv02.FactoryDirectory;
using Payslipv02.Interfaces;

namespace Payslipv02.TaxDirectory
{
    public class TaxBrackets : ITaxBrackets
    {
        private readonly ITaxBracketInformation _taxInfo = Factory.NewTaxBracketInformation();
        private readonly INumberVariables _payslipCalculationVariables = Factory.NewPayslipCalculationVariables();
        
        public Dictionary<string, double> Calculate(double annualSalary)
        {
            if (annualSalary > _payslipCalculationVariables.OneHundredEightyThousand)
            {
                return _taxInfo.OverOneHundredEightyThousand;
            }
            
            if (annualSalary > _payslipCalculationVariables.EightySevenThousand && annualSalary <= _payslipCalculationVariables.OneHundredEightyThousand)
            {
                return _taxInfo.OneHundredEightyThousand;
            }
            
            if (annualSalary > _payslipCalculationVariables.ThirtySevenThousand && annualSalary <= _payslipCalculationVariables.EightySevenThousand)
            {
                return _taxInfo.EightySevenThousand;
            }
            
            if (annualSalary > _payslipCalculationVariables.EighteenThousandTwoHundred && annualSalary <= _payslipCalculationVariables.ThirtySevenThousand)
            {
                return _taxInfo.ThirtySevenThousand;
            }

            return _taxInfo.EighteenThousandTwoHundred;
        }
    }
}