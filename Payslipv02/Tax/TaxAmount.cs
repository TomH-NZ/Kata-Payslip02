using System;

namespace Payslipv02.Tax
{
    public class TaxAmount
    {
        public double CalculatePayPeriodTaxValue(double annualSalary)
        {
            var payPeriodsPerYear = 12;
            var bracket = Factory.Factory.CreateTaxBrackets();
            var taxBracket = bracket.Calculate(annualSalary);
            
            var taxAmount = Math.Round
                (((annualSalary - taxBracket["LowerBracketLimit"]) *
                 (taxBracket["TaxPercent"] / 100) + taxBracket["PreviousBracketTaxTotal"]) / payPeriodsPerYear, MidpointRounding.ToEven);
            
            return taxAmount;
        }
    }
}