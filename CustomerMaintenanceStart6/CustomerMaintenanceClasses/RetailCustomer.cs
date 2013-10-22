using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    /*  For lab 6 - Complete exercise 14 - 1, parts 1 - 4.  
     *  Modify the console application you wrote to test the WholesaleCustomer 
     *  and RetailCustomer classes.  Test the constructor for each class 
     *  as well as any properties or methods that were added to each class.
     *  Complete exercise 14 - 2.  Re-rum the console application you wrote 
     *  to test the new implementation of the CustomerList class.  
     *  Note that there are no new methods or properties 
     *  so you shouldn't have to change the test program at all.  
     *  Add code to the tester for the CustomerList class t
     *  hat adds several WholesaleCustomers and several RetailCustomers 
     *  to a CustomerList and then prints the list.
     */

namespace CustomerMaintenanceClasses
{
    public class RetailCustomer : Customer
    {
        private string homePhone;

        //defual constructor
        public RetailCustomer()
        {
        }

        public RetailCustomer(string fName, string lName, string em, string hp): base(fName, lName, em)
        {
            this.HomePhone = hp;
        }

        public string HomePhone
        {
            get
            {
                return homePhone; 
            }
            set 
            {
                homePhone = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Home Phone: " + this.HomePhone;
        }
    }
}
