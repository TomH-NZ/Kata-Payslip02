using System;

namespace Payslipv02.SalaryDirectory
{
    public class Salary : ISalary
    {
        public double PayPeriodAmount(double annualSalary)
        {
            const double payPeriodsPerYear = 12; //ToDo: pay periods per year

            return Math.Round(annualSalary / payPeriodsPerYear, MidpointRounding.ToEven);
        }
    }
}