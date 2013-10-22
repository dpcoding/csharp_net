using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerMaintenanceClasses
{
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

    public class Customer
    {
        protected string firstName, lastName, email;

        // default constructor
        public Customer() { }

        // constructor takes three
        public Customer(string fName, string lName, string em)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.email = em;
        }

        //Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {   // page 418 step 2 adding exception if the values of the 3 inputs are longer than 30 char.
                if (value.Length > 30)
                {
                    throw new ArgumentException(
                        "Maximum length of first name is 30 characters.");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {               
                return lastName;
            }
            set
            {   // page 418 step 2 adding exception
                if (value.Length > 30)
                {
                    throw new ArgumentException(
                        "Maximum length of last name is 10 characters.");
                }
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Length > 30)
                {   // page 418 step 2 adding exception
                    throw new ArgumentException(
                        "Maximum length of an email address is 30 characters.");
                }
                email = value;
            }
        }

        // using override instead of virtual, since ToString is already overrided on ToString of Ojbect.
        public override string ToString()
        {
            return firstName + " " + lastName + " << " + email + " >>";
        }
    }
}
