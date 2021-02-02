using Payslipv02.FactoryDirectory;
using Payslipv02.PayslipDirectory;

namespace Payslipv02
{
    class Program
    {
        static void Main(string[] args)
        {
            var tomH = Factory.NewEmployeePayslip();
            tomH.NewEmployeePayslip();
        }
    }
}