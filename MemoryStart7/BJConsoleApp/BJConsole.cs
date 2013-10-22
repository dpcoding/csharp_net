using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace BJConsoleApp
{
    /**
     * For Lab 6 - Blackjack in Console 
     */

    public class BJConsole
    {
        static BJHand bHand = new BJHand();
        static string hitOrStay = "";
        static int /*total = 0,*/ count = 2, dealerTotal = 0;
        static Random dealerCards = new Random();

        static Deck d1 = new Deck();

        #region "Blackjack Console App without using Player and Dealer classes"
        /*static void Main(string[] args)
        {
            Console.Title = "Welcome to Dylan's Simple Blackjack!";
            StartGame();       
            //Console.ReadLine();
        }*/
        #endregion

        #region "Blackjack Console App using Player and Dealer classes"
        static void Main(string[] args)
        {
            Console.Title = "Welcome to Dylan's Simple Blackjack!";
            StartGame();
            //Console.ReadLine();
        }
        #endregion

        public static void StartGame()
        {
            dealerTotal = dealerCards.Next(16, 21);
            d1.Shuffle();
            bHand.AddCard(d1.Deal());
            bHand.AddCard(d1.Deal());
            do
            {
                Console.WriteLine("Dealer Total is " + dealerTotal);// check dealer's total
                Console.WriteLine();
                Console.WriteLine("$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$");
                Console.WriteLine("$   WELCOME TO SIMPLE BLACKJACK!  $");
                Console.WriteLine("$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$~$");
                Console.Write("\nYou were dealt \n" + bHand
                      + "\nYour total is " + bHand.Score + ".\nWould you like to hit or stay? ");
                //Console.WriteLine("Total Cards " + count);
                hitOrStay = Console.ReadLine().ToLower();
            } while (!hitOrStay.Equals("hit") && !hitOrStay.Equals("stay"));
            Game();
        }
        
        public static void Game()
        {
            if (hitOrStay.Equals("hit"))
            {
                Hit();
            }
            else if (hitOrStay.Equals("stay"))
            {
                if (bHand.Score > dealerTotal)
                {
                    Console.WriteLine("\nCongrats! You won the game! The dealer's total was "
                        + dealerTotal + ".\nWould you like to play again? y/n");
                    PlayAgain();
                }
                else if (bHand.Score < dealerTotal)
                {
                    Console.WriteLine("\nOoops, you lost! The dealer's total was "
                        + dealerTotal + ".\nWould you like to play again? y/n");
                    PlayAgain();
                }
            }
            Console.ReadLine();
        }
        
        public static void Hit()
        {
            count += 1; // use Is5Cards() 
            bHand.AddCard(d1.Deal());// Need to check how to show the value of next card
            Console.WriteLine("\nYou were dealt a(n) " + bHand[bHand.NumCards - 1] 
                + ".\nYour new total is " + bHand.Score + ".");
            if (bHand.IsBlackJack || bHand.Score == 21 )
            {
                Console.Write("\nYou got Blackjack! The dealer's total was "
                    + dealerTotal + ".\nWould you like to play again (y/n)? ");
                //Console.WriteLine("Total Cards " + count);
                PlayAgain();
            }
            else if (bHand.Is5Cards && bHand.Score < 21)
            {
                Console.Write("\nYou have 5 cards, Blackjack! The dealer's total was "
                    + dealerTotal + ".\nWould you like to play again (y/n)? ");
                //Console.WriteLine("Total Cards " + count);
                PlayAgain();
            }
            else if (bHand.IsBusted)
            {
                Console.Write("\nYou busted. The dealer's total was "
                    + dealerTotal + ".\nWould you like to play again (y/n)? ");
                //Console.WriteLine("Total Cards " + count);
                PlayAgain();
            }
            else if (bHand.Score < 21)
            {
                
                do
                {
                    if (count == 4)
                        Console.WriteLine("You have " + count + " cards in hand now. Try one more?");
 
                    Console.Write("\nWould you like to hit or stay? ");
                    hitOrStay = Console.ReadLine().ToLower();
                } while (!hitOrStay.Equals("hit") && !hitOrStay.Equals("stay"));
                Game();
            }
        }

        public static void Stay()
        {            
            //Console.ReadLine();
        }

        public static void PlayAgain()
        {
            string playAgain = "";
            do
            {
                playAgain = Console.ReadLine().ToLower();
            } while (!playAgain.Equals("y") && !playAgain.Equals("n"));

            if (playAgain.Equals("y"))
            {
                Console.WriteLine("\nPress enter to start a new game!");
                Console.ReadLine();
                Console.Clear();
                dealerTotal = 0;
                count = 2;
                bHand = new BJHand();
                StartGame();
            }
            else if (playAgain.Equals("n"))
            {
                Console.WriteLine("\nPress enter to close Dylan's Simple Blackjack. Come back again soon!");
                Console.ReadLine();
                Environment.Exit(0);
            }

        }
    }
}
