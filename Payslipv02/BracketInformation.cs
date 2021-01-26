namespace Payslipv02
{
    public class BracketInformation
    {
       //Array layout is upper tax bracket, lower tax bracket, tax percent and previous tax amount
       double[] EighteenThousandTwoHundred = { 18200, 0, 0, 0};
       double[] ThirtySevenThousand = {37000, 18201, 19, 0};
       double[] EightySevenThousand = {87000, 37001, 32.5, 3572};
       double[] OneHundredEightyThousand = {180000, 87001, 37, 19822};
       double[] OverOneHundredEightyThousand = {180001, 180001, 45, 54232};
    }
}