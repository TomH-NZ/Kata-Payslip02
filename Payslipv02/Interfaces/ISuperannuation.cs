namespace Payslipv02.SuperannuationDirectory
{
    public interface ISuperannuation
    {
        double CalculateValue(double payPeriodIncome, double superannuationRate);
    }
}