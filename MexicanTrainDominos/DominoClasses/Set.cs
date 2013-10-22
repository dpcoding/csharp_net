using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses
{
    /* Lab 4 - Complete the Set and Hand (of dominos) classes as discussed in class.  
     * Write a console application to test the classes.   *** / means done
        •	dominos (list of Dominos) /
        •	DominosRemaining (property get) /
        •	IsEmpty (property get) /
        •	Set (default constructor - creates a set of double 12 dominos) /
        •	Set (int numPips - creates a set of dominos with double blanks to double the number of pips in the parameter) /
        •	Shuffle (no parameters and no return value) /
        •	Deal (no parameters and returns a Domino) /
        •	ToString (the usual) /
     */

    public class Set
    {
        private List<Domino> mySet = new List<Domino>();

        #region Properties
        public int DominosRemaining
        {
            get
            {
                return mySet.Count;
            }
        }

        public bool IsEmpty
        {
            get
            {
                if (mySet.Count == 0)
                    return true;
                else
                    return false;
            }
        }
        #endregion

        #region Default constructor
        public Set()
        {        
            for (int pip1 = 0; pip1 <= 12; pip1++)
            {
                for (int pip2 = 0; pip2 <= 12; pip2++)
                {
                    mySet.Add(new Domino(pip1, pip2));                
                }
            }
        }

        public Set(int numDomino)
        {
            for (int pip1 = 0; pip1 <= numDomino; pip1++)
            {
                for (int pip2 = 0; pip2 <= numDomino; pip2++)
                {
                    mySet.Add(new Domino(pip1, pip2));
                }
            }
        }
        #endregion

        #region Methods
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < mySet.Count; i++)
            {
                int rnd = random.Next(0, mySet.Count);
                Domino temp = mySet[i];
                mySet[i] = mySet[rnd];
                mySet[rnd] = temp;
            }
        }

        public Domino Deal()
        {
            Domino tempCard = mySet[0];
            mySet.RemoveAt(0);
            return tempCard;
        }

        public override string ToString()
        {
            string str = "";
            foreach (Domino d in mySet)
            {
                str += (d.ToString() + "\n");
            }
            return str;
        }
        #endregion
    }
}
