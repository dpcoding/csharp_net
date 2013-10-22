using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeClassLibrary
{
   public class HourlyEmployee
   {
      //private char employeeType;
      private double hourlyRate;
      private double hoursPerWeek;
      private double grossPay;

      public const double OVERTIME = 40;
      public const double FEDTAXRATE = .18;
      public const double RETIREMENT = .10;
      public const double SOCIAL_SECURITY = .06;

      public HourlyEmployee()
      {

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
              if (value == '1' || value == '2')
              {
                  employeeType = value;
              }
              else
              {
                  throw new ArgumentOutOfRangeException("employeeType", value, "Employee types are 1, or 2.");
              }
          }
      }
       */

      //constructor with two arguments
      public HourlyEmployee(double rate, double hours)
      {
          hourlyRate = rate;
          hoursPerWeek = hours;
      }

      public double Hours
      {
         get
         {
            return hoursPerWeek ;
         }
         set
         {
            if (value > 0)
            {
               hoursPerWeek = value;
            }
            else
            {
               throw new ArgumentOutOfRangeException(
                  "hoursPerWeek", value, "Hours clocked can not be 0 or a negative number.");
            }
         }
      }

      public double HourlyRate
      {
         get
         {
            return hourlyRate;
         }
         set
         {
            if (value >= 10)
            {
               hourlyRate = value;
            }
            else
            {
               throw new ArgumentOutOfRangeException(
                  "hourlyRate", value, "Minumum wage is $10.00/hour.");
            }
         }
      }

      public double CalculateHourlyGrossPay()
      {
   
            if (Hours <= 40)
            {
               grossPay = hoursPerWeek * hourlyRate;
            }
            else
            {
               grossPay = OVERTIME * hourlyRate + ((hoursPerWeek - OVERTIME) * hourlyRate * 1.5);
            }
            return grossPay;
         
      }

      public double CalculateTakeHomePay()
      {
         return CalculateHourlyGrossPay() - (
           CalculateHourlyGrossPay() * (FEDTAXRATE + RETIREMENT + SOCIAL_SECURITY));
      }

      public double CalculateFedTaxPay()
      {
          return CalculateHourlyGrossPay() * FEDTAXRATE;
      }

      public double CalculateRetirementPay()
      {
          return CalculateHourlyGrossPay() * RETIREMENT;
      }

      public double CalculateSocialSecurityPay()
      {
          return CalculateHourlyGrossPay() * SOCIAL_SECURITY;
      }
    
   }
}
