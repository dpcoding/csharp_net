using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FundRaiser
{
    public partial class FundRaiser : Form
    {
        public FundRaiser()
        {
            InitializeComponent();
        }
         
        #region Mycode for Lab 7 Fund Raiser App

        decimal m_decTotalRaised = 0;

        void CalculateDonation(decimal decDonatedAmount,
        out decimal decNetDonation, ref decimal decTotalDonations)
        {
            const double dblCOSTS = 0.17;
            decNetDonation = decDonatedAmount -
                        (decDonatedAmount * (decimal)dblCOSTS);
            decTotalDonations = decTotalDonations + decNetDonation;
        }


        decimal CalculateDonation(decimal decDonatedAmount)
        {
            const double dblCOSTS = 0.17;
            decimal decNetDonation;

            decNetDonation = decDonatedAmount -
                 (decDonatedAmount * (decimal)dblCOSTS);

            return decNetDonation;
        }


        private void btnDonate_Click(object sender, EventArgs e)
        {
            decimal decDonation;    // amount donated
            decimal decAfterCosts;  // amount for charity

            decDonation = Decimal.Parse(txtDonation.Text);
            CalculateDonation(decDonation, out decAfterCosts, ref m_decTotalRaised); // the new line
            lblDonatedValue.Text = String.Format("{0:C}", decAfterCosts);

            // this needs omit when add the above new line (m_decTotalRaised += decAfterCosts;)
            lblTotalValue.Text = String.Format("{0:C}", m_decTotalRaised);

        }
        #endregion
    }
}
