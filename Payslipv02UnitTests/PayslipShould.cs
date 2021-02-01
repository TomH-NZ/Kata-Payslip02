using System;
using Payslipv02.SalaryDirectory;
using Payslipv02.SuperannuationDirectory;
using Payslipv02.TaxDirectory;
using Xunit;

namespace Payslipv02UnitTests
{
    public class PayslipShould
    {
        [Theory]
        [InlineData(9, 9, 1)]
        [InlineData(1000, 9, 90)]
        [InlineData(1500, 9, 135)]
        [InlineData(5004, 9, 450)]
        public void ReturnCorrectSuperannuationAmountWhenGivenPayPeriodAmount(double payPeriodAmount, double superannuationRate, double expected)
        {
            //Arrange
            var super = new Superannuation();
            
            //Act
            var result = super.CalculateValue(payPeriodAmount, superannuationRate);
            
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

        [Theory]
        [InlineData(120000, 10000)]
        [InlineData(60000, 5000)]
        [InlineData(72000, 6000)]
        [InlineData(28500, 2375)]
        public void ReturnCorrectPayPeriodAmountWhenGivenAnAnnualSalary(double annualSalary, double expected)
        {
            //Arrange
            var payAmount = new Salary();

            //Act
            var result = payAmount.PayPeriodAmount(annualSalary);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}