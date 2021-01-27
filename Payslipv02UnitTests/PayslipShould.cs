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
            var super = new Superannuation();
            
            //Act
            var result = super.CalculateValue(payPeriodAmount);
            
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnTaxAmountOf922WhenGivenAnAnnualSalaryOf60050()
        {
            //Arrange
            var tax = new Tax();

            //Act
            var result = tax.Calculate(60050);

            //Assert
            Assert.Equal(922, result);
        }
    }
}