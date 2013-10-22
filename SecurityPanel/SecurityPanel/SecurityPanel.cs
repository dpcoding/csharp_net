using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecurityPanel
{
    public partial class SecurityPanel : Form
    {
        public SecurityPanel()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string strMessage;
            int code = Int32.Parse(txtSecurityCode.Text);
            txtSecurityCode.Clear(); // or, txtSecurityCode.Text = "";

            switch ( code )  
            {
	            case 0: case 1: case 2: case 3: case 4: case 5: 
	            case 6: case 7: case 8: case 9: 
                       strMessage = "Restricted Access"; break;
	            case 1645: case 1689:
                       strMessage = "Technicians"; break;
	            case 8345:
                       strMessage = "Custodians"; break;
	            case 9998: case 1006: case 1007: case 1008:
                           strMessage = "Scientists"; break;
	            default:
                       strMessage = "Access Denied"; break;
            } // end switch

            // add record into textbox
            lstLogEntry.Items.Add(DateTime.Now + "\t" + strMessage); 
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "1";
        }

        private void btnNumberKey_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtSecurityCode.Text += btn.Text; 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Clear(); // or, txtSecurityCode.Text = "";
        }
    }
}
