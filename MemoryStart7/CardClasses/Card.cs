using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CardClasses
{
    public class Card
    {
        private int value;
        private int suit;
        private static string[] values = {"", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King"};
        private static string[] suits = {"", "Clubs", "Diamonds", "Hearts", "Spades"};
        Random generator = new Random();

        // default constructor
        public Card()
        {
            // get cards from generator for suit and value
            value = generator.Next(1, 14);
            suit = generator.Next(1, 4);
        }

        //Constructor takes 2 arguments
        public Card(int v, int s)
        {
            // get cards from generator for suit and value
            value = v;
            suit = s;
        }

        // get and seters
        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public int Suit
        {
            get
            {
                return this.suit;
            }
            set
            {
                suit = value;
            }
        }

        // Might need more like IsBlack, IsHeart, HasMatchingValue, HasMatchingSuit
        public bool IsRed()
        {
            if (suit == 2 || suit == 3)
                return true;
            else
                return false;
        }

        public bool IsBlack()
        {
            if (suit == 1 || suit == 4)
                return true;
            else
                return false;
        }
        // added this at Lab 6
        public bool IsAce()
        {
            if (value == 1)
                return true;
            else
                return false;
        }

        public bool HasMatchingValue(Card other)
        {
            if (other.value == value)
                return true;
            else
                return false;
        }

        public bool HasMatchingSuit(Card other)
        {
            if (other.suit == suit)
                return true;
            else
                return false;
        }

        private string FileName
        {
            get
            {
                return "card" + values[value].Substring(0, 1) 
                    + suits[suit].Substring (0, 1) + ".jpg";
            }
        }

        private void Show(PictureBox p)
        {
            p.Image = Image.FromFile(System.Environment.CurrentDirectory 
                + "\\Cards\\" + FileName);
        }

        public static void ShowBack(PictureBox p)
        {
            p.Image = Image.FromFile(System.Environment.CurrentDirectory
                + "\\Cards\\black_back.jpg");
        }

        public override string ToString()
        {
 	         return values[value] + " of " + suits[suit];
            
            /*string str = "";
            foreach (Card c in )
            {
                str += (c.ToString() + "\n");
            }
            return str;*/
        }
    }
}
