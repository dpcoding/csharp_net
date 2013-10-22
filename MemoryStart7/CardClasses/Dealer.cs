using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    
    // For Lab 6
    public class Dealer : Player
    {
        private Deck d = new Deck();

        public Dealer()
            : base()
        {
            d.Shuffle();
        }

        public void Play()
        {
            while (Score <= 17)
            {
                AddCard(d.Deal());
            }
        }

        public Card Deal()
        {
            return d.Deal();
        }
    }
}
