using System;

namespace Payslipv02.Superannuation
{
    public class Superannuation
    {
        public double CalculateValue(double payPeriodIncome, double superannuationRate)
        {
            return Math.Round(payPeriodIncome * superannuationRate / 100, MidpointRounding.ToEven);
        }
    }
}