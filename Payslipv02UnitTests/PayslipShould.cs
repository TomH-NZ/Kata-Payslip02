using System;
using Payslipv02;
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
            var Super = new Superannuation();
            
            //Act
            var result = Super.CalculateValue(payPeriodAmount);
            
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnTaxRateOf37PercentWhenGivenIncomeOfOneHundredThousand()
        {
            //Arrange
            
            //Act
            
            //Assert
        }
    }
}