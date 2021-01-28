using System;

namespace Payslipv02
{
    public class Superannuation
    {
        public double CalculateValue(double payPeriodIncome)
        {
            const double superannuationRate = 9;

            var superannuationAmount = Math.Round(payPeriodIncome * superannuationRate / 100, MidpointRounding.ToEven);

            return superannuationAmount;
        }
    }
}