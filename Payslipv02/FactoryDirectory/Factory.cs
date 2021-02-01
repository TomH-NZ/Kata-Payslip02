using Payslipv02.Interfaces;
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
    }
}