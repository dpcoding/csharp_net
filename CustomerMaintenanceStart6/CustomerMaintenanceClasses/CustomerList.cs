using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    // Exercise 14-2 step 2 Modify CustomerList class so it inherits the List<Customer> class
    public class CustomerList : List <Customer>
    {
        //protected List<Customer> customers;
        // pg. 419 more infor on 402 - step 10 and 11
        public delegate void ChangeHandler(CustomerList customers);
        public event ChangeHandler Changed;

        /*public CustomerList()
        {
            customers = new List<Customer>();
        }*/
        // 13-1 step 5 indicating how many Customer objects are in the list
        // Exercise 14-2
        /*public int Count
        {  
            get
            {
                return customers.Count;
            }
        }*/
        //13-1 step 5 - An indexer that uses an integer as an index
        public new Customer this[int i]
        {
            get
            {
                /*if (i < 0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if (i >= customers.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }*/
                return base[i];
            }
            set
            {
                base[i] = value;
                Changed(this);
            }
        }

        //step 5
        public new void Add(Customer c)
        {
            base.Insert(0, c);
            //base.Add(customer);
            Changed(this);
        }

        /*public void Add(string firstName, string lastName, string email)
        {
            Customer c = new Customer(firstName, lastName, email);
           base.Add(c);
        }*/

        public Customer GetCustomerByIndex(int i)
        {
            return base[i];
        }

        //step 5
        public new void Remove(Customer customer)
        {
            base.Remove(customer);
            Changed(this);
        }
        //step 5
        public void Fill()
        {
            //customers = CustomerDB.GetCustomers();
            List<Customer> customers = CustomerDB.GetCustomers();
            foreach (Customer c in customers)
                base.Add(c);
        }
        //step 5
        public void Save()
        {
            CustomerDB.SaveCustomers(this);
        }

        // step 8 overloaded + amd - operators
        public static CustomerList operator +(CustomerList c1, Customer c)
        {
            c1.Add(c);
            return c1;
        }

        public static CustomerList operator -(CustomerList c1, Customer c)
        {
            c1.Remove(c);
            return c1;
        }
        /*
        public override string ToString()
        {
            string str = "";
            foreach (Customer c in customers)
            {
                str += (c.ToString() + "\n");
            }
            return str;
        }*/
    }
}
