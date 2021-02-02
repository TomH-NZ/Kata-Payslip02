using System;

namespace Payslipv02.SuperannuationDirectory
{
    public class Superannuation : ISuperannuation
    {
        public double CalculateValue(double payPeriodIncome, double superannuationRate)
        {
            return Math.Round(payPeriodIncome * superannuationRate / 100, MidpointRounding.ToEven);
        }
    }
}