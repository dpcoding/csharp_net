using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CloneCustomer
{
    // For Lab 8
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer customer;
        //private List<Customer> customers = new List<Customer>();
        private CustomerList customers = new CustomerList();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            customer = new Customer("John", "Mendez", "jmendez@msysco.com");
            lblCustomer.Text = customer.GetDisplayText();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(txtCopies.Text); i++)
            {
                // Cast Customer as object since Clone() returns an object
                customers.Add((Customer) customer.Clone());
            }

            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
            {
                lstCustomers.Items.Add(c.GetDisplayText());
            }
        }

    }
}