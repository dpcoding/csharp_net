using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses; // added

namespace DeckTester
{
    /* Lab 4 - Complete the Deck and Hand (of cards) classes as discussed in class.  
     * Write a console application to test the classes.
     */
    class DeckTester
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();

            Console.WriteLine("--- Testing overloading toString of d1 ");
            Console.WriteLine(d1);

            Console.WriteLine("\n--- Testing NumCards");
            Console.WriteLine(d1.NumCards);

            Console.WriteLine("\n--- Testing Deal - expecting Deal twice");
            Console.WriteLine(d1.Deal());
            Console.WriteLine(d1.Deal());

            Console.WriteLine("\n--- Testing IsEmpty - expecting false");
            Console.WriteLine(d1.IsEmpty);
            
            Console.WriteLine("\nTesting Shuffle - expecting shuffled d1");
            d1.Shuffle();
            Console.WriteLine(d1);


            Console.WriteLine("Please enter any key to continue...");
            Console.ReadLine();
        }
    }
}
