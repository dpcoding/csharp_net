using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoanClassLibrary;

namespace LoanConsoleApp
{
    class LoanConsoleApp
    {
        static void Main(string[] args)
        {
            int years;
            double loanAmount;
            double interestRate;
            string inValue;
            char anotherLoan = 'N';

            do
            {
                GetInputValues(out loanAmount,
                               out interestRate,
                               out years);

                Loan ln = new Loan(loanAmount, interestRate, years);
                ln.DeterminePaymentAmount();
                Console.WriteLine();
                Console.WriteLine(ln.ReturnAmortizationSchedule());
                ln.DetermineTotalInterestPaid();
                Console.WriteLine("Payment Amount: {0:C}", ln.PaymentAmount);
                Console.WriteLine("Interest Paid over Life of Loan: {0:C}",
                                  ln.TotalInterestPaid);
                Console.Write("Do another Calculation? (Y or N)");
                inValue = Console.ReadLine();
                anotherLoan = Convert.ToChar(inValue);

            }
            while ((anotherLoan == 'Y') || (anotherLoan == 'y'));
        }

        // Prompts user for loan data
        static void GetInputValues(out double loanAmount,
                                   out double interestRate,
                                   out int years)
        {
            string sValue;

            Console.Write("Loan Amount: ");
            sValue = Console.ReadLine();
            loanAmount = Convert.ToDouble(sValue);
            Console.Write("Interest Rate (as a decimal value): ");
            sValue = Console.ReadLine();
            interestRate = Convert.ToDouble(sValue);
            Console.Write("Number of Years to Finance: ");
            sValue = Console.ReadLine();
            years = Convert.ToInt32(sValue);
        }
    }
}
