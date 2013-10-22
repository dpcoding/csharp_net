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
    // For Lab 5 - Complete the parts of exercise 13 - 1 (parts 4, 6, 9, 12 and 13)
    // that modify the GUI to use the Customer class features you added in lab 4.
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        // Pg. 392 12-1 step 9 Declare a class variable customer of type Customer with value  of null 
        private CustomerList customers = new CustomerList();

        // 10 not clare for GEtDisplayText here
        public void frmCustomers_Load(object sender, System.EventArgs e)
        {
            //customers = CustomerDB.GetCustomers(); // using delegate and event
            customers.Changed += new CustomerList.ChangeHandler(HandleChange);
            customers.Fill();
            FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();// Clear listBox first  
            for (int i = 0; i < customers.Count; i++)
            //foreach (Customer c in customers)
            {
                Customer c = customers[i];
                lstCustomers.Items.Add(c.ToString()); // need to ask about those two lines
            }
        }
        // 11
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer newCustomerForm = new frmAddCustomer(); //Create a new instance object
            Customer customer = newCustomerForm.GetNewCustomer();
            if (customer != null)
            {
                /*customers.Add(customer);
                CustomerDB.SaveCustomers(customers);
                FillCustomerListBox();*/
                customers += customer; // step 9
            }
        }
        // 12 Confirm the delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message;
            int i = lstCustomers.SelectedIndex;
            // *** Try to prompt message of no customer selcted. ***
            /*if (lstCustomers.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a customer.");
            }
            else*/ if (i != -1)// if it returns something, not -1
            {
                //Customer customer = (Customer)customers[i]; 
                Customer customer = customers[i];
                message = "Are you sure you want to delete "
                    + customer.FirstName + " " + customer.LastName + " from the list?"; // need the selected name
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    /*customers.Remove(customer);
                    CustomerDB.SaveCustomers(customers);
                    FillCustomerListBox();*/
                    customers -= customer; //// step 9
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // adding change event handler
        private void HandleChange(CustomerList customers)
        {
            customers.Save();
            FillCustomerListBox();
        }
    }
}