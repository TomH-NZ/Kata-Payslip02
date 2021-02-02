using System;
using Payslipv02.FactoryDirectory;

namespace Payslipv02.TaxDirectory
{
    public class TaxAmount : ITaxAmount
    {
        public double CalculatePayPeriodTaxValue(double annualSalary)
        {
            var payPeriodsPerYear = 12; // ToDo: pay periods per year
            var bracket = Factory.CreateTaxBrackets();
            var taxBracket = bracket.Calculate(annualSalary);
            
            var taxAmount = Math.Round
                (((annualSalary - taxBracket["LowerBracketLimit"]) *
                 (taxBracket["TaxPercent"] / 100) + taxBracket["PreviousBracketTaxTotal"]) / payPeriodsPerYear, MidpointRounding.ToEven);
            
            return taxAmount;
        }
    }
}