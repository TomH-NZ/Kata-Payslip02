using Payslipv02.Interfaces;
using Payslipv02.PayslipDirectory;
using Payslipv02.SalaryDirectory;
using Payslipv02.SuperannuationDirectory;
using Payslipv02.TaxDirectory;

namespace Payslipv02.FactoryDirectory
{
    public static class Factory
    {
        public static ITaxBrackets CreateTaxBrackets()
        {
            return new TaxBrackets();
        }

        public static ITaxBracketInformation NewTaxBracketInformation()
        {
            return new TaxBracketInformation();
        }

        public static ISalary NewSalaryCalculation()
        {
            return new Salary();
        }

        public static ITaxAmount NewTaxAmount()
        {
            return new TaxAmount();
        }

        public static ISuperannuation NewSuperannuationCalculation()
        {
            return new Superannuation();
        }

        public static IPayslipGenerator NewEmployeePayslip()
        {
            return new PayslipGenerator();
        }
    }
}