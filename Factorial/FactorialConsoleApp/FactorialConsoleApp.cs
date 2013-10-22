using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactorialClassLibrary;

namespace FactorialConsoleApp
{
    class FactorialConsoleApp
    {
        static void Main(string[] args)
        {
            int result;

            string moreData;
            int n;

            DisplayInformation();

            do
            {
                n = InputN();
                result = Factorial.RecursiveFactorial(n);
                DisplayNFactorial(n, result);
                moreData = PromptForMoreCalculations();
            }
            while (moreData == "y");
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("n! represents the product"
                               + " of the first n integers");
        }

        public static int InputN()
        {
            string inValue;
            int n;

            Console.Write("\nEnter the number to "
                           + "use to compute n! ");
            inValue = Console.ReadLine();
            n = Convert.ToInt32(inValue);
            return n;
        }

        public static void DisplayNFactorial(int n, int result)
        {
            Console.WriteLine("{0}! is {1}.", n, result);
        }

        public static string PromptForMoreCalculations()
        {
            string moreData;
            Console.WriteLine("\nDo you want to calculate"
                               + " another factorial?");
            Console.WriteLine("Enter y for another "
                               + "calculation. \nAny other "
                               + "character to stop.");
            moreData = Console.ReadLine();
            return moreData;
        }
    }
}
