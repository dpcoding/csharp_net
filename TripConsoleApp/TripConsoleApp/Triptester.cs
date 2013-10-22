using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripClassLibrary;

namespace TripConsoleApp
{
    class Triptester
    {
        static void Main(string[] args)
        {
       
          Trip a = new Trip();
          a.Distance = GetMilesTraveled();
          a.GasCost = GetGasPrice();
          a.Gallons = GetGallons();

          Console.Clear();
          Console.WriteLine(a.ToString());

          Console.ReadLine();
        }

        public static double GetMilesTraveled()
        {
           double inValue;
           Console.Write("Enter Miles Traveled: ");
           inValue = double.Parse(Console.ReadLine());
           return inValue;
        }

        public static decimal GetGasPrice()
        {
           decimal inValue;
           Console.Write("Enter Total Gas Price: ");
           inValue = decimal.Parse(Console.ReadLine());
           return inValue;
        }

        public static double GetGallons()
        {
           double inValue;
           Console.Write("Enter Gallons Consumed: ");
           inValue = double.Parse(Console.ReadLine());
           return inValue;
        }

    }
}
