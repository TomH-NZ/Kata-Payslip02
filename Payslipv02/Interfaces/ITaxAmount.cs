namespace Payslipv02.TaxDirectory
{
    public interface ITaxAmount
    {
        double CalculatePayPeriodTaxValue(double annualSalary);
    }
}