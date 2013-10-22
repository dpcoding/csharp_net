using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeClassLibrary
{
    public class Employee
    {
        private string employeeName;
        private double employeeTotalSales;

        // need to make following public instead of private
        public const double COMMISSION = .07;
        public const double FEDTAXRATE = .18;
        public const double RETIREMENT = .10;
        public const double SOCIAL_SECURITY = .06;

        //constructor
        public Employee()
        {

        }

        //constructor with one name argument
        public Employee(string name)
        {
            employeeName = name;
        }

        //constructor with two arguments
        public Employee(string name, double totalSales)
        {
            employeeName = name;
            employeeTotalSales = totalSales;
        }
        
        //constructor with six arguments
        public Employee(string name, double totalSales, double commission,
           double fedTaxRate, double retirement, double socialSecurity)
        {
           employeeName = name;
           employeeTotalSales = totalSales;
           commission = COMMISSION;
           fedTaxRate = FEDTAXRATE;
           retirement = RETIREMENT;
           socialSecurity = SOCIAL_SECURITY;
        }
        
        //Properties
        public string EmployeeName
        {
           get
           {
              return employeeName;
           }
           set
           {
              employeeName = value;
           }
        }

        public double EmployeeTotalSales
        {
           get
           {
              return employeeTotalSales;
           }
           set
           {
              employeeTotalSales = value;
           }
        }

        public double Commission
        {
           get
           {
              return COMMISSION;
           }
        }

        public double FedTaxRate
        {
           get
           {
              return COMMISSION;
           }
        }

        public double Retirement
        {
           get
           {
              return RETIREMENT;
           }
        }

        public double SocialSecurity
        {
           get
           {
              return SOCIAL_SECURITY;
           }
        }

        public double CalculateGrossPay()
        {
           return employeeTotalSales * Commission;
        }

        public double CalculateTakeHomePay( )
        {
            return CalculateGrossPay() - (
              CalculateGrossPay() * (FEDTAXRATE + RETIREMENT + SOCIAL_SECURITY));  
        }

        public double CalculateFedTaxPay()
        {
            return CalculateGrossPay() * FEDTAXRATE;
        }

        public double CalculateRetirementPay()
        {
           return CalculateGrossPay() * RETIREMENT;
        }

        public double CalculateSocialSecurityPay()
        {
            return CalculateGrossPay() * SOCIAL_SECURITY;
        }

        public override string ToString()
        {
           return "Employee Name: " +
               employeeName +
               "\nTotal Sales: " +
               employeeTotalSales.ToString("c") +
               "\nGross Pay (7%): " +
               CalculateGrossPay().ToString("c") + 
               "\nFederal Tax (18%): " +
               CalculateFedTaxPay().ToString("c") +
               "\nRetirement contribution (10%): " +
               CalculateRetirementPay().ToString("c") +
               "\nSocial Security (6%): " +
               CalculateSocialSecurityPay().ToString("c") +
               "\nTotal Net Pay: " +
               CalculateTakeHomePay().ToString ("c");
        }
    }
}
