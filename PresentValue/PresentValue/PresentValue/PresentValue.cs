using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentValue
{
   public partial class frmPresentValue : Form
   {
      public frmPresentValue()
      {
         InitializeComponent();
      }

      private decimal PresentValue(decimal futureValue, double rate, int year)
      {
         decimal amount = futureValue / (decimal)Math.Pow(1 + (rate / 100.0), year);
         return amount;
      }

      private void btnCalculate_Click(object sender, EventArgs e)
      {
         // get input from the user
         decimal futureValue = decimal.Parse(txtFutureValue.Text);
         double rate = double.Parse(txtRate.Text);
         int years = (int)(updYear.Value);
         decimal amount;

         // set output header
         txtBox1.Text = "Year\tAmount on Deposit Needed\r\n";

	     for (int counter = 5; counter <= years; counter += 5)
	     {
             amount = PresentValue(futureValue, rate, counter);
		     txtBox1.Text += counter + "\t" + String.Format("{0:C}", amount) +"\r\n";
	     }

      }
   }
}
