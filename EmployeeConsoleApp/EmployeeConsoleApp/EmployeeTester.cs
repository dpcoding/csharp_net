using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//need to using statement
using EmployeeClassLibrary;

namespace EmployeeConsoleApp
{
    class EmployeeTester
    {
        static void Main(string[] args)
        {
            /*
            // testing with user input
           Employee employeeObject = new Employee();
           employeeObject.EmployeeName = AskForEmployeeName();
           employeeObject.EmployeeTotalSales = AskForEmployeeTotalSales();

           Console.Clear();
           Console.WriteLine(employeeObject.ToString());
            */
           
            // testing without user input
           Employee e = new Employee();
           e.EmployeeName = "Sam";
           Console.WriteLine("Employee Name: " + e.EmployeeName);
           e.EmployeeTotalSales = 10000;
           Console.WriteLine("Total Sales: " + 
                e.EmployeeTotalSales.ToString("c"));
           Console.WriteLine("Gross Pay (7%): " +
                e.CalculateGrossPay().ToString("c"));
           Console.WriteLine("Federal Tax (18%): " +
                e.CalculateFedTaxPay().ToString("c"));
           Console.WriteLine("Retirement contribution (10%): " +
                e.CalculateRetirementPay().ToString("c"));
           Console.WriteLine("Social Security (6%): " +
                e.CalculateSocialSecurityPay().ToString("c"));
           Console.WriteLine("Total Net Pay: " +
                e.CalculateTakeHomePay().ToString("c"));
            

           Console.ReadLine();

        }

        public static string AskForEmployeeName()
        {
           string inValue;
           Console.Write("Enter Employee Name: ");
           inValue = Console.ReadLine();                                                    
           return inValue;
        }

        public static double AskForEmployeeTotalSales()
        {
           double inValue;
           Console.Write("Enter Total Sales: ");
           inValue = double.Parse(Console.ReadLine());
           return inValue;
        }
    }
}
