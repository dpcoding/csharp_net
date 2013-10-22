using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorialClassLibrary
{
    public class Fib
    {
        // methods
        public static int RecursiveFib(int n)
        {
            int result = 1;
                               
            if (n == 0 && n == 1)
                return 1;
            else
            {
                result = RecursiveFib(n - 1) + RecursiveFib(n - 2);
                return result;
            }
        }

        public static int IterativeFib(int n)
        {
            int result = 1;
            //for (i = 0; i <n; i--) from Adam
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
