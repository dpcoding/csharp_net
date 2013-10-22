using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses; // added

namespace HandTester
{
    class HandTester
    {
        /* Lab 4 - Complete the Deck and Hand (of cards) classes as discussed in class.  
         * Write a console application to test the classes.
         */
            /*Card c1 = new Card(3, 4);
            Card c2 = new Card(6, 4);
            Card c3 = new Card(1, 4);
            Card c4 = new Card(12, 2);
            Card c5 = new Card(8, 1);
            Card c6 = new Card(4, 3);
            Card c7 = new Card(10, 1);*/


        // Lab 6 - Blackjack in Console
        static string hitOrStay = "";
        static int total = 0, count = 1, dealerTotal = 0;



        static void Main(string[] args)
        {
            BJHand h1 = new BJHand();
            BJHand h2 = new BJHand();




            Deck d1 = new Deck();
            d1.Shuffle();

            Card cOne = d1.Deal();
            Card cTwo = d1.Deal();
            Card cThree = d1.Deal();
            Card cFour = d1.Deal();
            Card cFive = d1.Deal();

            Card dealerOne = d1.Deal();
            Card dealerTwo = d1.Deal();

            h2.AddCard(dealerOne);
            h2.AddCard(dealerTwo);

            dealerTotal = h2.Score;

            BJHand h3 = new BJHand(d1, 2);
            BJHand h4 = new BJHand(d1, 0);

            #region Testing for Lab 4
            /*
            Console.WriteLine("--- Testing default constructor h1, expecting blank");
            Console.WriteLine(h1);

            Console.WriteLine("\n--- Testing bool HasCard - before adding any card, expecting false");
            Console.WriteLine(h1.HasCard(c1));

            Console.WriteLine("\n--- Testing int NumCard - before adding any card, expecting 0");
            Console.WriteLine(h1.NumCards);

            Console.WriteLine("\n--- Testing the other constructor/ToString after adding two cards,");
            Console.WriteLine("--- Expecting 2");
            h1.AddCard(c1);
            h1.AddCard(c3);
            Console.WriteLine(h1);

            Console.WriteLine("\n--- Testing int NumCards - before adding two more cards");
            Console.WriteLine(h1.NumCards);

            Console.WriteLine("\n--- Testing bool HasCards - before adding two more cards");
            Console.WriteLine(h1.HasCard(c1));

            Console.WriteLine("\n--- Testing AddCard - two more cards added");
            h1.AddCard(c2);
            h1.AddCard(c3);
            Console.WriteLine(h1);

            Console.WriteLine("\n--- Testing int NumCards - after adding two more");
            Console.WriteLine(h1.NumCards);

            Console.WriteLine("\n--- Testing bool HasCard - after adding two more");
            Console.WriteLine(h1.HasCard(c1));

            h1.Discard(c3);
            Console.WriteLine("\n--- Testing Discard - after removing third card");
            Console.WriteLine(h1.NumCards);

            Console.WriteLine("\n--- Testing int IndexOf - specify c2");
            Console.WriteLine(h1.IndexOf(c2)); // not sure how to test this
            */

            /*
            Console.WriteLine("n--- Testing shuffered d1 ---");
            Console.WriteLine(d1.NumCards);
            Console.WriteLine(h3);
            */
            #endregion

            #region Testing BJHand
            /*Console.WriteLine("\n--- Testing HasAce - specify h2 -- expecting false and 0 card");
            Console.WriteLine(h2.HasAce); 
            Console.WriteLine(h3.NumCards);

            //Console.WriteLine("\n--- Testing HasAce - specify h3 -- expecting ture");
            //Console.WriteLine(h3.HasAce);
            h3.AddCard(c2);
            h3.AddCard(c3);
            h3.AddCard(c4);
            Console.WriteLine("\n--- Testing c2(6), c3(Ace) and c4(Queen) Values - ");
            Console.WriteLine(c2.Value);
            Console.WriteLine(c3.Value);
            Console.WriteLine(c4.Value);

            Console.WriteLine("\n--- Testing NumCards - expecting 3 cards");
            Console.WriteLine(h3.NumCards);

            Console.WriteLine("\n--- Testing Score - expecting score of 17");
            Console.WriteLine(h3.Score);

            Console.WriteLine("\n--- Testing HasAce - specify h3 -- expecting ture ");
            Console.WriteLine(h3.HasAce);

            Console.WriteLine("\n--- Testing IsBusted - before adding one more card -- expecting false ");
            Console.WriteLine(h3.IsBusted);

            Console.WriteLine("\n--- Testing IsBlackJack - before adding one more card -- expecting false ");
            Console.WriteLine(h3.IsBlackJack);

            Console.WriteLine("\n--- Testing IsBusted - after adding c5(8) to h3 -- expecting ture ");
            h3.AddCard(c5);
            Console.WriteLine(h3.IsBusted);
            Console.WriteLine("Hand(h3) total Score: " + h3.Score);

            Console.WriteLine("\n--- Testing IsBlackJack - before adding c3(1, 4) and c7(7, 1) - expecting false");            
            Console.WriteLine("Number of cards in h4 hand: "  + h4.NumCards);
            Console.WriteLine("Hand(h4) total Score: " + h4.Score);
            Console.WriteLine(h4.IsBlackJack);

            Console.WriteLine("\n--- Testing IsBlackJack - after adding c3(1, 4) and c7(7, 1) -- expecting ture ");
            h4.AddCard(c3);
            h4.AddCard(c7);
            Console.WriteLine("Number of cards in h4 hand: " + h4.NumCards);
            Console.WriteLine("Hand(h4) total Score: " + h4.Score);
            Console.WriteLine(h4.IsBlackJack);

            Console.WriteLine("\n--- Testing Discard - after removing c3(1, 4) -- expecting 1 card of 10 ");
            h4.Discard(c3);
            Console.WriteLine("Number of cards in h4 hand: " + h4.NumCards);
            Console.WriteLine("Hand(h4) total Score: " + h4.Score);*/

            #endregion

            #region "BlackJack Console App"

            Console.Title = "Welcome To Dylan's Simple Blackjack!";
            h1.AddCard(cOne);
            h1.AddCard(cTwo);

            total = h1.Score;
            //h3.AddCard(cOne);
            //h3.AddCard(cTwo); 
            //h3.AddCard(d1.Deal());

            Console.WriteLine("You were dealt \n" + h1);

            Console.WriteLine("Your score is " + total);

            do
            {
                Console.WriteLine("\nWould you like to hit or stay?");
                hitOrStay = Console.ReadLine().ToLower();
            } while (!hitOrStay.Equals("hit") && !hitOrStay.Equals("stay"));

        }     



        

            #endregion
    }
}
