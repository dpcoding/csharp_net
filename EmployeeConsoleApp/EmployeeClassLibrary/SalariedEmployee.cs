using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeClassLibrary
{
    public class SalariedEmployee
    {
        
        private double salaryTotal;
        

        public const double OVERTIME = 40;
        public const double FEDTAXRATE = .18;
        public const double RETIREMENT = .10;
        public const double SOCIAL_SECURITY = .06;

        //constructor
        public SalariedEmployee()
        {

        }

       /*
        //constructor with one name argument
        public SalariedEmployee(char type)
        {
            employeeType = type;
        }
       */

        //constructor with one argument
        public SalariedEmployee(double salary)
        {
           salaryTotal = salary;
        }
        
        
        
        //Properties
        /*
        public char EmployeeType
        {
           get
           {
              return employeeType;
           }
           set
           {
              if (value == '1'||value == '2')
              {
                employeeType = value ;
              }
              else
              {
                  throw new ArgumentOutOfRangeException("employeeType", value, "Employee types are 1, or 2.");
              }
           }
        }
         */

        public double SalaryTotal
        {
           get
           {
              return salaryTotal;
           }
           set
           {
              salaryTotal = value;
           }
        }
       
        public double FedTaxRate
        {
           get
           {
              return FEDTAXRATE;
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
           return salaryTotal;
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
           return "Employee Type: " +
               "" +
               "\nTotal Salary: " +
               salaryTotal.ToString("c") +
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

    }// end of class employee
}
