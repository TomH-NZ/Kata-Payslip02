using System;

namespace Payslipv02
{
    public class TaxAmount
    {
        public double CalculatePayPeriodTaxValue(ITaxBrackets bracket, double annualSalary)
        {
            var payPeriodsPerYear = 12;

            var taxBracket = bracket.Calculate(annualSalary);
            
            var taxAmount = Math.Round
                ((annualSalary - taxBracket["LowerBracketLimit"] *
                 (taxBracket["TaxPercent"] / 100) + taxBracket["PreviousBracketTaxTotal"]) / payPeriodsPerYear, MidpointRounding.ToEven);

            return taxAmount;
        }
    }
}