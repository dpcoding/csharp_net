using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses
{
    /* Lab 4 - Complete the Set and Hand (of dominos) classes as discussed in class.  
     * Write a console application to test the classes. ** / means done
        •	dominos (list of Dominos) /
        •	Count (property get) /
        •	IsEmpty (property get) /
        •	Score (property get - adds the score of each of dominos in the hand) /
        •	Hand /
        •	Hand (Set, numDominos) /
        •	Add (Domino) /
        •	HasDomino (int pipValue) returns a boolean / need to check those two
        •	HasDoubleDomino (int pipValue) /
        •	GetDomino (int pipValue) returns a Domino and removes it from the hand /
        •	GetDoubleDomino (int pipValue) /
        •	Draw (Set) adds a domino from the set to the hand /
        •	Eventually we'll add Play that plays a domino on a train
        •	ToString /
     */
    public class Hand
    {
        private List<Domino> myHand = new List<Domino>();

        #region Properties
        public int Count
        {
            get
            {
                return this.myHand.Count;
            }
        }

        public bool IsEmpty
        {
            get
            {
                if (myHand.Count == 0)
                    return true;
                else
                    return false;
            }
        }

        public int Score
        {
            get
            {
                int score = 0;
                foreach (Domino d in myHand)
                    score += d.GetPip1 + d.GetPip2;
                return score; // need to fiquir how to score
            }
        }
        #endregion

        #region Constructors
        public Hand()
        {
        }

        // Hand (Set, numDominos)
        public Hand(Set s, int numDominos)
        {
            Domino tempSet = new Domino();
            for (int i = 0; i < numDominos; i++)
            {
                tempSet = s.Deal();
                myHand.Add(tempSet);
            }
        }
        #endregion

        #region Methods
        public void Add(Domino d)
        {
            myHand.Add(d);
        }
        
        public bool HasDomino(int value)
        {
            foreach (Domino d in myHand)
            {
                if (d.GetPip1 == value || d.GetPip2 == value) // might need to check pip2 value
                    return true;
            }
            return false;
        }

        public bool HasDoubleDomino(int pipValue)
        {
            foreach (Domino d in myHand)
            {
                if (d.GetPip1 == pipValue && d.GetPip2 == pipValue)
                    return true;
            }
            return false;
        }

        public Domino GetDomino(int pipValue)
        {
            Domino tempDomino = myHand[0];
            myHand.RemoveAt(0);
            return tempDomino;
        }

        // need GetDoubleDomino (int pipValue)
        public Domino GetDoubleDomino(int pipValue)
        {
            Domino tempDomino = myHand[0];
            myHand.RemoveAt(0);
            return tempDomino;
        }

        public void Draw(Set s)
        {
            Domino tempDomino = s.Deal();
            myHand.Add(tempDomino);
        }

        public Domino this[int i]
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

        //IndexOf(Domino) - returns an integer
        public int IndexOf(Domino d)
        {
            for (int i = 0; i < myHand.Count; i++)
            {
                if (i == d.GetPip1)
                    return 1;
            }
            return -1;
        }

        public override string ToString()
        {
            string str = "";
            foreach (Domino d in myHand)
            {
                str += (d.ToString() + "\n");
            }
            return str;
        }

        #endregion
    }
}
