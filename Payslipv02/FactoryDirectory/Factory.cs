using Payslipv02.Tax;

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