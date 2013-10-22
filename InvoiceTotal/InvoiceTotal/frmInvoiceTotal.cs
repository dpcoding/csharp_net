using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
	{
		public frmInvoiceTotal()
		{
			InitializeComponent();
		}

        // TODO: 2. declare class variables for array and list here
        decimal[] invoiceTotals = new decimal[5];
        int totalsIndex = 0;

        // Only needed for step 9 and 10; initialize the variable for the step 9. list
        List<decimal> invoiceTotalsList = new List<decimal>();

        private void btnCalculate_Click(object sender, EventArgs e)
		{
            try
            {
                
                if (txtSubtotal.Text == "")
                {
                    MessageBox.Show(
                        "Subtotal is a required field.", "Entry Error");
                }
                else
                {
                    decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                    if (subtotal > 0 && subtotal < 10000)
                    {
                        decimal discountPercent = 0m;
                        if (subtotal >= 500)
                            discountPercent = .2m;
                        else if (subtotal >= 250 & subtotal < 500)
                            discountPercent = .15m;
                        else if (subtotal >= 100 & subtotal < 250)
                            discountPercent = .1m;
                        decimal discountAmount = subtotal * discountPercent;
                        decimal invoiceTotal = subtotal - discountAmount;

                        discountAmount = Math.Round(discountAmount, 2);
                        invoiceTotal = Math.Round(invoiceTotal, 2);

                        txtDiscountPercent.Text = discountPercent.ToString("p1");
                        txtDiscountAmount.Text = discountAmount.ToString();
                        txtTotal.Text = invoiceTotal.ToString();
                  
                        if (totalsIndex < 5)
                        {
                            //2. those two are added for adding the total and update
                            invoiceTotals[totalsIndex] = invoiceTotal;
                            totalsIndex++;

                            // Only needed for step 9 and 10
                            invoiceTotalsList.Add(invoiceTotal); //add total to list
                            //invoiceTotalsList++;
                        }
                        else
                        {
                            MessageBox.Show("You have entered the MAX datasets. Please exit.", "Entry Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Subtotal must be greater than 0 and less than 10,000.",
                            "Entry Error");
                        
                    }
                }
              
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter a valid number for the Subtotal field.", 
                    "Entry Error");
            }
            txtSubtotal.Focus();
        }

		private void btnExit_Click(object sender, EventArgs e)
		{
            // TODO: add code that displays dialog boxes here
            Array.Sort(invoiceTotals);
            string message = "Invoice Total: \n";
            foreach (decimal total in invoiceTotals)
            {
                if (total != 0)
                {
                    message += total.ToString("c") + "\n";
                }
            }
            MessageBox.Show(message, "Order Totals");

            // needed for step 9 and 10
            //display the message box for the list
            invoiceTotalsList.Sort();
            message = "";
            foreach (decimal total in invoiceTotalsList)
            {
                message += total.ToString("c") + "\n";
            }
            MessageBox.Show(message, "List - Order Totals");

            this.Close();
		}

	}
}