using System;

namespace Payslipv02.PayslipDirectory
{
    public class PayslipGenerator
    {
        public void NewEmployeePayslip()
        {
            Console.WriteLine("Welcome to the Payslip Generator. /n");
            Console.WriteLine("Please enter your first name: ");
            var employeeFirstName = Console.ReadLine();
            Console.WriteLine("Please enter your surname: ");
            var employeeSurname = Console.ReadLine();

            Console.WriteLine("Please enter your annual salary: ");
            double annualSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter in the superannuation rate: ");
            double superannuationRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter in the pay period start date (dd:mm:yyyy): ");
            var payPeriodStart = Console.ReadLine();
            Console.WriteLine("Please enter in the pay period end date (dd:mm:yyyy): ");
            var payPeriodEnd = Console.ReadLine();

            Console.WriteLine("/n");
            Console.WriteLine("/n");

            Console.WriteLine("Your payslip is: ");
            
        }
    }
}