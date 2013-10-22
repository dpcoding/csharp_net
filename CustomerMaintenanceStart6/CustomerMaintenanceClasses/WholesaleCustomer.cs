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
    public class WholesaleCustomer : Customer
    {
        private string company;

        //defual constructor
        public WholesaleCustomer() { }
        //Constructor accepts four parameeters and calls the base class constructor
        public WholesaleCustomer(string fName, string lName, string em, string company): base(fName, lName, em)
        {
            this.Company = company;
        }

        public string Company
        {
            get
            {
                return company;
            }
            set 
            {
                company = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " (" + Company + ")";
        }
    }
}
