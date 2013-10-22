using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    #region Lab 4 requirments
    /* Lab 4 - Complete the Deck and Hand (of cards) classes as discussed in class.  
     * Write a console application to test the classes.
     *  •	cards (list of Card) -
        •	NumCards (property get) -
        •	Hand (default constructor) -
        •	Hand (Deck, numCards as parameters - creates a hand of 5 cards from the deck) **  EC
        •	AddCard(Card)  -
        •	Discard(index) - returns a card 
        •	HasCard(Card) - returns a boolean
        •	HasCard(value) - **  EC -
        •	HasCard(value, suit) - **  EC -
        •	IndexOf(Card) - returns an integer
        •	IndexOf(value) - **  EC -
        •	IndexOf(value, suit) - **  EC -
        •	ToString - the usual
        */
    #endregion
    // For Lab 6
    public class Hand
    {
        //cards (list of Card)
        protected List<Card> myHand = new List<Card>();

        #region Properties
        // NumCards (property get) -
        public int NumCards
        {
            get
            {
                return myHand.Count;
            }
        }
        #endregion

        #region Constructors
        // default constructor
        public Hand()
        {
            
        }

        // Hand (Deck, numCards as parameters - creates a hand of 5 cards from the deck)
        public Hand(Deck c, int numCards)
        {
            Card tempCard = new Card();
            for (int i = 0; i < numCards; i++)
            {
                tempCard = c.Deal();
                myHand.Add(tempCard); // adding card to hand
            }
        }
        #endregion

        #region Methods
        // AddCard(Card)
        public void AddCard(Card c)
        {
            myHand.Add(c);
        }

        // Discard(index) - returns a card
        public void Discard(Card c)
        {
            myHand.Remove(c);
        }

        // from Mari 
        public Card Discard(int index)
        {
            Card c = myHand[index];
            myHand.Remove(c);
            return c;
        }

        // HasCard(Card) - returns a boolean
        public bool HasCard(Card other)
        {
            foreach (Card c in myHand)
            {
                if (c.Value == other.Value)
                    return true;              
            }
            return false;
        }

        public bool HasCard(int value)
        {
            foreach (Card c in myHand)
            {
                if (c.Value == value)
                    return true;
            }
            return false;
        }

        public bool HasCard(int value, int suit)
        {
            foreach (Card c in myHand)
            {
                if (c.Value == value && c.Value == suit)
                    return true;
            }
            return false;
        }
        // from
        public Card GetCard(int index)
        {
            return myHand[index];
        }

        public Card this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if (i >= myHand.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return myHand[i];
            }
            set
            {
                myHand[i] = value;
            }
        }

        //IndexOf(Card) - returns an integer
        public int IndexOf(Card c)
        {
            for (int i = 0; i < myHand.Count; i++)
            {
                if (i == c.Value)
                    return 1;
            }
            return -1;
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < myHand.Count; i++)
            {
                if (i == value)
                    return 1;
            }
            return -1;
        }

        public int IndexOf(int value, int suit)
        {
            for (int i = 0; i < myHand.Count; i++)
            {
                if (i == value && i == suit)
                    return 1;
            }
            return -1;
        }

        // ToString - the usual
        public override string ToString()
        {
            string str = "";
            foreach (Card c in myHand)
            {
                str += (c.ToString() + "\n");
            }
            return str;
        }

        #endregion

    } 
}
    