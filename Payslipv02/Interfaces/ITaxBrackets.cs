using System.Collections.Generic;

namespace Payslipv02
{
    public interface ITaxBrackets
    {
        Dictionary<string, double> Calculate(double annualSalary);
    }
}