using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorialClassLibrary
{
    public class Factorial
    {
        // methods
        public static int RecursiveFactorial(int n)
        {
            int result = 1;
            // stop when n == 1                   
            if (n == 1)
                return 1;
            else // this else is not nessasery
            {
                result = RecursiveFactorial(n - 1) * n;
                return result;
            }
        }

        public static int IterativeFactorial(int n)
        {
            int result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
