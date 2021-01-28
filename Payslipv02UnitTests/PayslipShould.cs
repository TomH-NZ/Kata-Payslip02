using System;
using Payslipv02;
using Payslipv02.Tax;
using Xunit;

namespace Payslipv02UnitTests
{
    public class PayslipShould
    {
        [Theory]
        [InlineData(9, 1)]
        [InlineData(1000, 90)]
        [InlineData(1500, 135)]
        [InlineData(5004, 450)]
        public void ReturnCorrectSuperannuationAmountWhenGivenPayPeriodAmount(double payPeriodAmount, double expected)
        {
            //Arrange
            var super = new Superannuation();
            
            //Act
            var result = super.CalculateValue(payPeriodAmount);
            
            //Assert
            Assert.Equal(expected, result);
        }
        

        [Theory]
        [InlineData(60050, 922)]
        [InlineData(30000, 187)]
        [InlineData(100000, 2053)]
        [InlineData(200000, 5269)]
        [InlineData(18000, 0)]
        public void ReturnCorrectPeriodTaxAmountWhenGivenAnAnnualSalary(double annualSalary, double expected)
        {
            //Arrange
            var payPeriodTax = new TaxAmount();

            //Act
            var result = payPeriodTax.CalculatePayPeriodTaxValue(annualSalary);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}