using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerMaintenanceClasses;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 12-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        // 5 for adding Customer and declare a class variable, customer, initial to null
        private Customer customer = null;

        // 6 
        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        /*private void frmProductMain_Load(object sender, System.EventArgs e)
        {
            customer = CustomerDB.GetCustomers();
            FillCustomerListBox();
        }*/

        /*private void FillProductListBox()
        {
            lstCustomers.Items.Clear();// Clear listBox first
            foreach (Customer c in customer)
            {
                lstCustomers.Items.Add(c.GetDisplayText("\t"));
            }
        }*/
        // 7
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                customer = new Customer(txtFirstName.Text,
                                        txtLastName.Text, 
                                        txtEmail.Text);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName) &&
                   Validator.IsPresent(txtLastName) &&
                   Validator.IsPresent(txtEmail) &&
                   Validator.IsValidEmail(txtEmail);
        }
        // 8
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}