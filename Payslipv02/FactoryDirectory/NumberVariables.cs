namespace Payslipv02.FactoryDirectory
{
    public class NumberVariables : INumberVariables
    {
        public double OneHundredEightyThousand { get; } = 180000;
        public double EightySevenThousand { get; }= 87000;
        public double ThirtySevenThousand { get; }= 37000;
        public double EighteenThousandTwoHundred { get; }= 18200;
        //Add in tax percentage amounts (zero, 32, 37.5, 45)
        //Add in previous bracket tax amounts (3572, 19822, 54232)
        //Add in pay periods per year (12)

    }
}