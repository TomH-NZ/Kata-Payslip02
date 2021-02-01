using System.Collections.Generic;

namespace Payslipv02.Interfaces
{
    public interface ITaxBrackets
    {
        Dictionary<string, double> Calculate(double annualSalary);
    }
}