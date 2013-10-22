using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominoClasses;

namespace DominoTester
{
    class DominoTest
    {
        static void Main(string[] args)
        {
            /// This tester is for lab 2 -Domino.cs
            #region "Domino tester"
            Domino d1 = new Domino();
            Domino d2 = new Domino(1, 12);
            Domino d3 = new Domino(5, 5);
            Domino d4 = new Domino(9, 4);
            Domino d5 = new Domino();

            d1.GetPip1 = 2;// Don't need setters, but just try it
            d1.GetPip2 = 7;// Don't need setters, but just try it
            /*
            Console.WriteLine("------ Tester for Lab 2 - Domino Class ------");
            Console.WriteLine("--- Testing both constructors and override ToString for d1 and d2");
            Console.WriteLine("Default constructor (setters): " + d1);
            Console.WriteLine("Constructor takes pip1 and pip2: " + d2);
            Console.WriteLine("Random generator (d5): " + d5);
            Console.WriteLine("\n--- Testing IsDouble for d3. Expecting True");
            Console.WriteLine(d3.IsDouble());
            Console.WriteLine("\n--- Testing IsDouble for d4. Expecting False");
            Console.WriteLine(d4.IsDouble());
            Console.WriteLine("\n--- Testing Flip for d4. Expecting 1|12 to 12|1");
            Console.WriteLine("Before flip: " + d2);
            d2.Flip();
            Console.WriteLine("After flip: " + d2);
            Console.WriteLine("\n--- Testing Flip for randon generated d5. Expecting X|Y to Y|X");
            Console.WriteLine("Before flip: " + d5);
            d5.Flip();
            Console.WriteLine("After flip: " + d5);
            Console.WriteLine("\n--- Testing Score() for d5. Expecting ");
            Console.WriteLine(d5.Score());
            Console.WriteLine();
            */
            #endregion

            /// <summary>
            /// Those Hand and Set testers are for Lab 4
            /// </summary>
            #region "Hand tester"
            Hand h1 = new Hand();
            Hand h2 = new Hand();
            Set s1 = new Set();
            Set s2 = new Set();
            Set s3 = new Set(3);
            Console.WriteLine("--- Testing default constructor h1, expecting blank");
            Console.WriteLine(h1);
            Console.WriteLine("--- Testing Count of h1, expecting 0");
            Console.WriteLine(h1.Count);
            Console.WriteLine("--- Testing Add to h1, expecting an added Domino and new count 1");
            h1.Add(d4);
            Console.WriteLine(h1);
            Console.WriteLine(h1.Count);
            Console.WriteLine("--- Testing IsEmpty to h1, expecting False");
            Console.WriteLine(h1.IsEmpty);
            Console.WriteLine("--- Testing HasDomino to h1, expecting True");
            Console.WriteLine(h1.HasDomino(2));
            Console.WriteLine("--- Testing HasDomino to h1, expecting False");
            Console.WriteLine(h1.HasDomino(9));
            Console.WriteLine("--- Testing HasDoubleDomino to h1, expecting False");
            Console.WriteLine(h1.HasDoubleDomino(7));
            Console.WriteLine("--- Testing HasDoubleDomino to h1, expecting True afte adding d3(5, 5)");
            h1.Add(d3);
            Console.WriteLine(h1.HasDoubleDomino(5));
            Console.WriteLine("--- Current dominos in h1");
            Console.WriteLine(h1);
            Console.WriteLine("--- Testing GetDomino from h1, expecting d1(2, 7)");
            Console.WriteLine(h1.GetDomino(0));
            Console.WriteLine("--- Current dominos in h1");
            Console.WriteLine(h1);
            Console.WriteLine("--- Testing GetDoubleDomino from h1, expecting d3(5, 5)");
            Console.WriteLine(h1.GetDoubleDomino(5));
            Console.WriteLine("--- Current dominos in h1, expecting 0");
            Console.WriteLine(h1.Count);
            Console.WriteLine("--- Testing Draw from s1, expecting one domino added to hand");
            h1.Draw(s1);
            Console.WriteLine(h1);
            Console.WriteLine("\n--- Testing Score for h1. Expecting 2");
            Console.WriteLine(h1.Score);
            #endregion
            
            #region Set tester
            // Set testing
            /*Console.WriteLine("--- Testing default constructor of Set, expecting 12 dominos ");
            //Console.WriteLine(s2);
            Console.WriteLine("--- Testing DominosRemaining, expecting 12 dominos ");
            Console.WriteLine(s2.DominosRemaining);
            Console.WriteLine("--- Testing IsEmpty, expecting False");
            Console.WriteLine(s2.IsEmpty);
            Console.WriteLine("--- Testing Shuffle on s2, expecting shuffled s2");
            s2.Shuffle();
            //Console.WriteLine(s2);
            Console.WriteLine("--- Testing Deal, expecting the first domino in s2");
            Console.WriteLine(s2.Deal());

            Console.WriteLine("--- Testing Constructor taking a number of Dominos on s3, expecting s3 with specified number 3");
            Console.WriteLine(s3);
            Console.WriteLine("Total Dominos in Set (s3) : " + s3.DominosRemaining);
            */
            #endregion
            Console.ReadLine();
        }
    }
}
