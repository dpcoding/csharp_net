using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterestCalculator
{
   public partial class InterestCalculator : Form
   {
      public InterestCalculator()
      {
         InitializeComponent();
      }

      private decimal FutureValue(decimal principal, double rate, int year)
      {
         decimal amount = principal * (decimal)Math.Pow(1 + rate / 100, year);
         return amount;
      }

      private void btnCalculate_Click(object sender, EventArgs e)
      {  
         // get input from the user
	      decimal principal = decimal.Parse(txtPrincipal.Text);
	      double rate = double.Parse(txtRate.Text);
	      int years = (int) (updYear.Value);
         int counter = 1;
	      decimal amount;
	
	      txtResult.Text = "Year\tAmount on Deposit\r\n";

	      for (int couter = 1; counter <= years; counter++)
	      {
		      amount = FutureValue(principal, counter, rate);
		      txtResult.Text += counter + "\t\" + String.Format("{0:C}", amount) + "\r\n";
	      }

       }
   }
}
