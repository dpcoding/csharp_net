using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace CardTester
{
    class CardTester
    {
        static void Main(string[] args)
        {
            Card c1 = new Card();
            Card c2 = new Card(1, 4);
            Card c3 = new Card(12, 3);
            Card c4 = new Card(8, 3);
            Card c5 = new Card(12, 4);
            Card c6 = new Card(9, 1);
            Card c7 = new Card(6, 1);
            Card c8 = new Card(11, 4);// Check why it throws exception

            Console.WriteLine("Testing for IsBack using Card(1, 4), expecting True: \t" + c2.IsAce());
            Console.WriteLine("Testing for IsRed using Card(1, 4), expecting False: \t" + c2.IsRed());
            Console.WriteLine();
            Console.WriteLine("Testing for HasMatchingValue using Card(12, 5) and Card(12, 5),\nExpecting Ture: " + c5.HasMatchingSuit(c3));
            Console.WriteLine();
            Console.WriteLine("Testing for HasMatchingValue using Card(12, 5) and Card(9, 1),\nExpecting False: " + c5.HasMatchingSuit(c6));
            Console.WriteLine();
            Console.WriteLine("Testing for HasMatchingSuit using Card(9, 1) and Card(1, 2),\nExpecting False: " + c6.HasMatchingSuit(c2));
            Console.WriteLine();
            Console.WriteLine("Testing for HasMatchingSuit using Card(12, 3) and Card(8, 3),\nExpecting Ture: " + c3.HasMatchingSuit(c4));
            Console.WriteLine();
            Console.WriteLine("-- Testing override ToString --");
            Console.WriteLine(c2.ToString());  
            Console.WriteLine(c6.ToString());
            Console.WriteLine(c7.ToString());
            //Console.WriteLine(c8.ToString());

            Console.ReadLine();
        }
    }
}
