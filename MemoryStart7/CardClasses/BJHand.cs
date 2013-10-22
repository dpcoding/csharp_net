using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    // For Lab 6
    // inheritant from Hand
    public class BJHand : Hand
    {
        #region Constructors
        // default constructor
        public BJHand() : base()
        {         
        }

        public BJHand(Deck d, int numCards) : base(d, numCards)
        {
        }
        #endregion

        #region Properties
        public int Score
        {
            get
            {
                int score = 0;
                foreach (Card c in myHand)
                {
                    if (c.Value > 10)
                        score += 10;
                    else
                        score += c.Value;
                }

                if (score <= 11 && HasAce)
                {
                    score += 10;
                }
                return score;
            }
        }

        public bool HasAce
        {
            get
            {
                foreach (Card c in myHand)
                {
                    if (c.Value == 1)
                        return true;         
                }
                return false;
            }
        }

        public bool IsBusted
        {
            get
            {             
                if (Score > 21)
                    return true;
                else
                    return false;
            }
        }

        public bool IsBlackJack
        {
            get
            {
                if (Score == 21 && NumCards == 2)
                    return true;
                else
                    return false;
            }
        }

        public bool Is5Cards
        {
            get
            {
                if (NumCards == 5 && Score <= 21)
                    return true;
                else
                    return false;
            }
        }
        #endregion


    }
}
