using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardClasses;

namespace Concentration
{
    public partial class boardForm : Form
    {
        public boardForm()
        {
            InitializeComponent();
        }
        /* Lab 1 final - last updated 4/25/13 */

        #region Instance Variables
        // you'll need an array of strings, 2 indexes and the number of matches
        //private string[] cards;
        private Card[] cards;
        private int index1 = -1, index2 = -1;
        private int matches = 0;
        // this is for the timer that displays the elapsed time
        private int seconds = 0;
        private int clickCount = 0;
        private int totalClickCount = 0;
        private string buttonText, textMsg;
        Random ran = new Random();
        #endregion

        #region Methods
        // you may need more methods but here's the list that I used
        // this should fill the cards (array of strings) with card file names
        private void FillCards()
        {
            //cards = new string[21]; // instanciate array
            
            cards = new Card[21];
            int index = 1;

            while (index < 21)
            {
                Card c = new Card();
                cards[index] = c;
                index++;
                //c.Suit = ran.Next(1, 4);
                cards[index] = c;
                index++;
            }
            //string[] values = { "a", "5", "j", "7", "k" };
           // string[] suits = { "c", "d", "h", "s" };

            // I used a pair of nested loops here instead of manually adding all 20 strings
            /*foreach (string value in values)
            {
                foreach (string suit in suits)
                {
                    cards[index] = "card" + value + suit + ".jpg";
                    index++;
                }
            }
            //cards[0] = "cardac,jpg";
            */
        }

        // determines if the 2 cards are a match.  The "value" of the card is in the filename.
        private bool IsMatch(int index1, int index2)
        {
            if (cards[index1].HasMatchingValue(cards[index2]))
                return true; // original
            else
                return false;
        }

        // shuffles the strings in the cards array
        private void ShuffleCards()
        {
            Card temp;
            //Random random = new Random();
            for (int i = 1; i < 21; i++)
            {
                int rnd = ran.Next(1, 21);
                temp = cards[i];
                cards[i] = cards[rnd];
                cards[rnd] = temp;
            }
        }
        
        // loads the specified card picture box with the filename from the array
        private void LoadCard(int i)
        {
            PictureBox card = (PictureBox)this.Controls["card" + i];
            cards[i].Show(card);
        }

        // loads an image for the back of a card in the specified card
        private void LoadCardBack(int i)
        {
            PictureBox card = (PictureBox)this.Controls["card" + i];
            Card.ShowBack(card);
        }

        // disables and hides the specified card
        private void HideCard(int i)
        {
            this.Controls["card" + i].Visible = false;
        }

        // disables and hides all cards
        private void HideAllCards()
        {
        }

        
        // disables the specified card
        private void DisableCard(int i)
        {
        }

        // disables all cards
        private void DisableAllCards()
        {
            for (int i = 1; i < 21; i++)
                this.Controls["card" + i].Enabled = false;
        }

        // enables and shows all of the cards
        private void ShowAllCards()
        {
            for (int i = 1; i < 21; i++)
                this.Controls["card" + i].Visible = true;
        }

        // enables the cards that are still visible on the board
        private void EnableAllVisibleCards()
        {

            for (int i = 1; i < 21; i++)
            {
                if (this.Controls["card" + i].Visible == true)
                    this.Controls["card" + i].Enabled = true;
            }
        }

        #endregion
        private void frmBoard_Load(object sender, EventArgs e)
        {
            gameTimer.Enabled = false; // true before; Not start the game/timer until a card is clicked
            lblElapsedTime.Text = seconds.ToString();

            // fill the cards array
            FillCards();
            ShuffleCards();
            for (int i = 1; i <= 20; i++)
            {
                // show the back of all cards
                LoadCardBack(i);
            }

            // show simple instruction when form loads 
            textBox1.Text = "You may start the game by clicking a card or the Start button. "  
                            + "Click two cards and try to pair them. "
                            + "The game ends when all the cards are paired.";

            lblTotalturns.Text = totalClickCount.ToString();

            buttonText = "START";
            btn1.Text = buttonText.ToString();          
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblElapsedTime.Text = seconds.ToString();
            /* this might be needed for changing text for button.
             * if matches not 10
             *  newGameButton.Text = "Stop game";
             * else
             *  newGameButton.Text = "New game";
             */
            
        }

        private void card_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = true; // false before
            lblElapsedTime.Text = seconds.ToString();

            totalClickCount++; // adding total clicks and displaying 
            lblTotalturns.Text = totalClickCount.ToString();

            if (totalClickCount != 1 || totalClickCount < 8 )
                textMsg = "Game started.\n\n Good luck!";
            
            textBox1.Text = textMsg.ToString();

            buttonText = "NEW GAME"; // Replace btn text to New Game from Start
            btn1.Text = buttonText.ToString();

            PictureBox card = (PictureBox)sender;
            int cardIndex = int.Parse(card.Name.Substring(4));

            #region click info
            /* if it's the first card clicked
             *      save the index
             *      load the card image
             *      disable the card so the user can't click the same card twice
             * else
             *      save the index of the second card
             *      load the card image
             *      disable all the cards 
             *      start the flip timer
             * end if
             */
            #endregion
            if (clickCount == 0)
            {
                index1 = cardIndex;
                LoadCard(index1);
                card.Enabled = false;
                clickCount++;
            }
            else if (clickCount == 1)
            {
                index2 = cardIndex;
                LoadCard(index2);
                DisableAllCards();
                flipTimer.Enabled = true;
                clickCount = 0;
            }
        }

        private void flipTimer_Tick(object sender, EventArgs e)
        {
            #region psudocode from dear Mari
            // stop the timer 
            /*  if there's a match
            *      hide the first card clicked
            *      hide the second card clicked
            *      reset both indexes
            *      increment the number of matches
            *      if the game is over
            *          if the user wants to play again
            *              shuffle the cards
            *              show the card backs and enable all of the cards
            *          else
            *              exit the application?
            *          end if
            *      else
            *          enable all of the cards left on the board
            *      end if
            * else
            *      show the back of the first card clicked
            *      show the back of the second card clicked
            *      reset both indexes
            *      enable all of the cards left on the board
            * end if
            */
            #endregion
            
            if (IsMatch(index1, index2))
            {
                HideCard(index1);
                HideCard(index2);
                index1 = -1; 
                index2 = -1;
                matches++;
                flipTimer.Enabled = false;
                // TODO: textMsg is not quite the way I would like 
                if (matches > 2 && matches < 7)
                {
                    textMsg = "Keep going! You are doing great!";
                }
                if (matches >= 7 && matches < 10)
                {
                    textMsg = "You are AMAZING. Almost there!";
                }

                if (matches == 10)
                {
                    gameTimer.Stop();
                    string done = "Good job!"; //TODO: show result # turned and time
                    MessageBox.Show(done, "Game Over");
                }
                else
                {
                    EnableAllVisibleCards();
                }
                textBox1.Text = textMsg.ToString();         
            }
            else
            {
                LoadCardBack(index1);
                LoadCardBack(index2);
                index1 = -1;
                index2 = -1;
                EnableAllVisibleCards();
                flipTimer.Enabled = false;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "START")
            {
                gameTimer.Enabled = true;
                textBox1.Text = "Game started.\n\n Good luck!";
                clickCount = 0;
                buttonText = "NEW GAME";
            }
            else if (btn1.Text == "NEW GAME")
            {
                seconds = 0;
                clickCount = 0;
                totalClickCount = 0;
                matches = 0;
                ShowAllCards();
                EnableAllVisibleCards();
                this.frmBoard_Load(this, null);

                textBox1.Text = "A new game is ready for you. "
                                + "\nYou may click a card or the START button to begin.";

                buttonText = "START";
            }

            btn1.Text = buttonText.ToString();
        }
    }
}
