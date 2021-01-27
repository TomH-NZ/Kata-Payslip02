using System;

namespace Payslipv02
{
    public class Tax
    {
        public double Calculate(double annualSalary)
        {
            const int payPeriodsPerYear = 12;
            var bracket = new TaxBracketInformation();

            if (annualSalary > 180000 )
            {
                var taxAmount = Math.Round(((annualSalary - bracket.OverOneHundredEightyThousand["LowerBracketLimit"]) *
                                 (bracket.OverOneHundredEightyThousand["TaxPercent"] / 100) +
                                 bracket.OverOneHundredEightyThousand["PreviousBracketTaxTotal"]) / payPeriodsPerYear, MidpointRounding.ToEven);

                return taxAmount;
            }

            if (annualSalary > 87000 && annualSalary <= 180000)
            {
                var taxAmount = Math.Round(((annualSalary - bracket.OneHundredEightyThousand["LowerBracketLimit"]) *
                                            (bracket.OneHundredEightyThousand["TaxPercent"] / 100) +
                                            bracket.OneHundredEightyThousand["PreviousBracketTaxTotal"]) / payPeriodsPerYear, MidpointRounding.ToEven);

                return taxAmount;
            }
            
            if (annualSalary > 37000 && annualSalary <= 87000)
            {
                var taxAmount = Math.Round(((annualSalary - bracket.EightySevenThousand["LowerBracketLimit"]) *
                                            (bracket.EightySevenThousand["TaxPercent"] / 100) +
                                            bracket.EightySevenThousand["PreviousBracketTaxTotal"]) / payPeriodsPerYear, MidpointRounding.ToEven);

                return taxAmount;
            }
            
            if (annualSalary > 18200 && annualSalary <= 37000)
            {
                var taxAmount = Math.Round(((annualSalary - bracket.ThirtySevenThousand["LowerBracketLimit"]) *
                                            (bracket.ThirtySevenThousand["TaxPercent"] / 100) +
                                            bracket.ThirtySevenThousand["PreviousBracketTaxTotal"]) / payPeriodsPerYear, MidpointRounding.ToEven);

                return taxAmount;
            }

            return 922;

        }
    }
}