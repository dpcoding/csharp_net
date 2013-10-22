using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenScraping2010
{
    public partial class FrmScreenScraping : Form
    {
        #region Instance Variables
        // string of HTML to extract prices from
        string strHTML = "<HTML><BODY><TABLE>" +
                       "<TR><TD>Antique Rocking Chair</TD>" +
                       "<TD>&&euro;82.67</TD></TR>" +
                       "<TR><TD>Silver Teapot</TD>" +
                       "<TD>&&euro;64.55</TD></TR>" +
                       "<TR><TD>Gold Pocket Watch</TD>" +
                       "<TD>&&euro;128.83</TD></TR>" +
                       "</TABLE></BODY></HTML>";
        #endregion

        public FrmScreenScraping()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Declare some local variables
            int intItemLocation; // index of desired item
            int intPriceBegin; // starting index of price
            int intPriceEnd; // ending index of price
            string strPrice; // extracted price

            // find items located in html index page and more ...
            intItemLocation = strHTML.IndexOf(cboItems.SelectedItem.ToString());
            intPriceBegin = strHTML.IndexOf("&euro;", intItemLocation);
            intPriceEnd = strHTML.IndexOf("</TD>", intPriceBegin);
            strPrice = strHTML.Substring(intPriceBegin,
                (intPriceEnd - intPriceBegin));
            lblResult.Text = strPrice.Replace("&euro;", "$");
        }

        private void FrmScreenScraping_Load(object sender, EventArgs e)
        {
            lblHTML.Text = strHTML;
        }
    }
}
