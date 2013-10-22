using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    // For Lab 6
    // inheritant from BJHand
    public class Player : BJHand
    {
        private bool stand = false;

        #region Constructors
        // default constructor
        public Player() : base()
        {
        }

        #endregion
        public bool CanHit
        {
            get
            {
                if (!IsBusted && stand == false)
                    return true;
                else
                    return false;
            }
        }

        public void Hit(Card c)
        {
            AddCard(c);
        }

        public void Stay()
        {
            stand = true;
        }

        
    }
}
