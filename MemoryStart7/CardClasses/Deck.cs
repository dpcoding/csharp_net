using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    // For Lab 6
    public class Deck
    {
        #region Instance Variables     
        // cards (list of Card)
        protected List<Card> myDeck = new List<Card>(52);

        #endregion

        #region Default constructor
        public Deck()
        {        
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int[] suits = { 1, 2, 3, 4 };

            //foreach (int value in values)
            for (int suit = 0; suit <= 3; suit++)
            {
                //foreach (int suit in suits)
                for (int value = 0; value <= 12; value++)
                {
                    myDeck.Add(new Card(values[value], suits[suit]));                
                }
            }
        }
        #endregion

        #region Properties
        // NumCards (property get)
        public int NumCards
        {
            get
            {
                return myDeck.Count;
            }
        }

        public bool IsEmpty
        {
            get
            {
                if (myDeck.Count == 0)
                    return true;
                else
                    return false;
            }
        }
        #endregion

        #region Methods

        //Deal (no parameters and returns a Card)
        public Card Deal()
        {
            Card tempCard = myDeck[0];
            myDeck.RemoveAt(0);
            return tempCard;          
            /*if (!IsEmpty)
                return myDeck[0];
            else
                return null;*/
             
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < myDeck.Count; i++)
            {
                int rnd = random.Next(0, myDeck.Count);
                Card temp = myDeck[i];
                myDeck[i] = myDeck[rnd];
                myDeck[rnd] = temp;
            }
        }
        
        public override string ToString()
        {
            string str = "";
            foreach (Card c in myDeck)
            {
                str += (c.ToString() + "\n");
            }
            return str;
        }

        #endregion
    }
}
