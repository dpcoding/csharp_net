using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominoClasses;

namespace DominoClasses
{
    public class Domino
    {
        /// <summary>
        /// For Lab 4
        /// </summary>
        private int pip1, pip2;
        private int score;
        private static int[] pip = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        Random generator = new Random();

        // Default constructor
        public Domino()
        {
            pip1 = generator.Next(0, 12);
            pip2 = generator.Next(0, 12);
        }

        public Domino(int p1, int p2)
        {
            pip1 = p1;
            pip2 = p2;
        }

        // pip1 and pip2 getters
        public int GetPip1
        {
            get
            {
                return this.pip1;
            }
            set
            {
                pip1 = value;
            }

        }

        public int GetPip2
        {
            get
            {
                return this.pip2;
            }
            set
            {
                pip2 = value;
            }
        }

        // methods 
        public int Score()
        {
            return pip1 + pip2; //Don't konw how Dominos score
        }

        public bool IsDouble()
        {
            if (pip1 == pip2)
                return true;
            else
                return false;
        }

        public void Flip()
        {
            Domino temp = new Domino();
            temp.pip1 = pip1;
            pip1 = temp.pip1;
            temp.pip2 = pip2;
            pip2 = temp.pip1;
            pip1 = temp.pip2;
        }

        public override string ToString()
        {
            return pip1 + " | " + pip2;
        }
        
    }
}
