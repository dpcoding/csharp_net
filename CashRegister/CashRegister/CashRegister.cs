using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CashRegister
{
   public partial class FrmCashRegister : Form
   {
      public FrmCashRegister()
      {
         InitializeComponent();
      }

      decimal subtotalValue = 0;

      private void btnEnter_Click(object sender, EventArgs e)
      {
         // add the current amount to the subtotal
         subtotalValue = decimal.Parse(txtCurrentPrice.Text);
         lblSubTotalValue.Text = String.Format("{0:C}", subtotalValue);
         txtCurrentPrice.Clear();
         // it's working with code above: decimal currentPrice = Decimal.Parse(lblSubTotalValue.Text.Substring(1));
         
      }

      private void btnNumberKey_Click(object sender, EventArgs e)
      {
         Button btn = (Button)sender;
         txtCurrentPrice.Text += btn.Text; 
      }

      private void btnTotal_Click(object sender, EventArgs e)
      { 
         int intsubtotalValue = (int) subtotalValue / 100;
         double taxRate;
         decimal taxValue;
         decimal totalValue;

         switch (intsubtotalValue)
         {
            case 0:
               taxRate = 0.05; break;
            case 1: case 2: case 3: case 4:
               taxRate = 0.075; break;
            default: taxRate = 0.1; break;
         }

         // display values in corresponding lables
         taxValue = subtotalValue * (decimal)taxRate;
         lblTaxValue.Text = String.Format("{0:C}", taxValue);
         totalValue = subtotalValue + taxValue;
         lblTotalValue.Text = String.Format("{0:C}", totalValue);
      }

      private void btnClear_Click(object sender, EventArgs e)
      {
         lblSubTotalValue.Text = "$0.00";
         lblTaxValue.Text = "$0.00";
         lblTotalValue.Text = "$0.00";
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         txtCurrentPrice.Text = "";
      }

   }
}
