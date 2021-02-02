using System;
using Payslipv02.FactoryDirectory;

namespace Payslipv02.PayslipDirectory
{
    public class PayslipGenerator : IPayslipGenerator
    {
        public void NewEmployeePayslip()
        {
            var salaryCalculation = Factory.NewSalaryCalculation();
            var taxCalculation = Factory.NewTaxAmount();
            var superannuationCalculation = Factory.NewSuperannuationCalculation();
            
            Console.WriteLine("Welcome to the Payslip Generator. \n");
            Console.WriteLine("Please enter your first name: ");
            var employeeFirstName = Console.ReadLine();
            Console.WriteLine("Please enter your surname: ");
            var employeeSurname = Console.ReadLine();

            Console.WriteLine("Please enter your annual salary: ");
            var annualSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter in the superannuation rate: ");
            var superannuationRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter in the pay period start date (dd/mm/yyyy): ");
            var payPeriodStart = Console.ReadLine();
            Console.WriteLine("Please enter in the pay period end date (dd/mm/yyyy): ");
            var payPeriodEnd = Console.ReadLine();

            Console.WriteLine("/n");
            Console.WriteLine("/n");

            Console.WriteLine("Your payslip is: ");
            Console.WriteLine($"Name: {employeeFirstName} {employeeSurname}");
            Console.WriteLine($"Pay Period: {payPeriodStart} to {payPeriodEnd}");
            Console.WriteLine($"Gross Income: {salaryCalculation.PayPeriodAmount(annualSalary)}");
            Console.WriteLine($"Income Tax: {taxCalculation.CalculatePayPeriodTaxValue(annualSalary)}");
            
            var netIncome = salaryCalculation.PayPeriodAmount(annualSalary) -
                            taxCalculation.CalculatePayPeriodTaxValue(annualSalary);
            var superAmount = superannuationCalculation.CalculateValue(salaryCalculation.PayPeriodAmount(annualSalary),
                superannuationRate);
            
            Console.WriteLine($"Net Income: {netIncome}");
            Console.WriteLine($"Superannuation Amount: {superAmount}");
            
        }
    }
}