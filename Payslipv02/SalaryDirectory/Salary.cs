
namespace Payslipv02.SalaryDirectory
{
    public class Salary : ISalary
    {
        public double PayPeriodAmount(double annualSalary)
        {
            const double payPeriodsPerYear = 12;

            return annualSalary / payPeriodsPerYear;
        }
    }
}