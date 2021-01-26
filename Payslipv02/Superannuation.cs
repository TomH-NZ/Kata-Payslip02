using System;

namespace Payslipv02
{
    public class Superannuation
    {
        public double CalculateValue(double payPeriodIncome)
        {
            const double SuperannuationRate = 9;

            var SuperannuationAmount = Math.Round(payPeriodIncome * SuperannuationRate / 100, MidpointRounding.ToEven);

            return SuperannuationAmount;
        }
    }
}