using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
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
            Customer p1 = new Customer();
            Customer p2 = new Customer("Jone", "Troutman", "jy@yahoo.com");
            Customer p3 = new Customer("Michael", "Young", "my@yahoo.com");
            Customer p4 = new Customer("Anna", "Liu", "aliu888@hotmail.com");
            Customer p5 = new Customer("Dylan", "Pan", "dylanpan@hotmail.com");

            // A CustomerList object 
            CustomerList customerList = new CustomerList();

            // Testing for Lab 6
            WholesaleCustomer w1 = new WholesaleCustomer("Casey", "Scott", "casey@gmail.com", "Pacific Health");
            WholesaleCustomer w2 = new WholesaleCustomer();
            RetailCustomer r1 = new RetailCustomer("Ron", "James", "jamesr@hotmail.com", "123456789");
            RetailCustomer r2 = new RetailCustomer();
            w2.FirstName = "Jason";
            w2.LastName = "Willson";
            w2.Email = "jw@hotmail.com";
            w2.Company = "Cysco";

            r2.FirstName = "Tom";
            r2.LastName = "Murphy";
            r2.Email = "tom_murphy@gmail.com";
            r2.HomePhone = "(541) 222-7890";

           // w1.Company = "Lane Community College";
           // r1.HomePhone = "(541) 234-4567"; // My defual constructor won't show homePhone



            Console.WriteLine("--- Testing override ToString of WholesaleCustomer and getters ---");
            Console.WriteLine(w1);
            Console.WriteLine("\n--- Testing override ToString of WholesaleCustomer and setters ---");
            Console.WriteLine(w2);
            Console.WriteLine("\n--- Testing override ToString of RetailCustomer and getters ---");
            Console.WriteLine(r1);
            Console.WriteLine("\n--- Testing override ToString of RetailCustomer and setters ---");
            Console.WriteLine(r2);
            Console.WriteLine("\n--- Testing ---");
            Console.WriteLine();

            
            Console.WriteLine("---Testing both constructors---");
            Console.WriteLine("Default constructor.  Expecting default values. :" + p1);
            Console.WriteLine("Overloaded constructor: " + p2);
            Console.WriteLine();

            Console.WriteLine("---Testing setters--- Expecting Bob Roberts rob_roberts@yahoo.com ---");
            p1.FirstName = "Bob"; // property setter
            p1.LastName = "Roberts";
            p1.Email = "rob_roberts@yahoo.com";

            Console.WriteLine(p1.FirstName);
            Console.WriteLine(p1.LastName);
            Console.WriteLine(p1.Email);

            Console.WriteLine("\n---Testing getters--- Expecting Jone Troutman jy@yahoo.com ---\n");
            Console.WriteLine(p2.FirstName);
            Console.WriteLine(p2.LastName);
            Console.WriteLine(p2.Email);

            // adding new customers to customerList
            customerList.Add(p1);
            customerList.Add(p2);
            customerList.Add(p3);
            customerList.Add(p4);

            Console.WriteLine("\n---Testing Add()--- added p1, p2, p3 and p4");
            Console.WriteLine(customerList.ToString());

            customerList.Remove(p4); // Remove p4

            Console.WriteLine("\n---Testing Remove()--- Removed p4, Anna Liu (aliu888 @hotmail.com)");
            Console.WriteLine(customerList.ToString());

            customerList.Fill(); // fill customers to customerList.

            Console.WriteLine("\n---Testing Fill()---");
            Console.WriteLine(customerList.ToString());
            Console.WriteLine();


            Console.WriteLine("\n---Testing Count()---");
            Console.WriteLine(customerList.Count);
            Console.WriteLine();

            Console.WriteLine("\n---Testing indexer()--- Selecting customerList[1]");
            Console.WriteLine(customerList[1].ToString());
            Console.WriteLine();

            customerList.Save();
            Console.WriteLine("\n---Testing Save()---");
            Console.WriteLine(customerList.ToString());

            customerList += p5;
            Console.WriteLine("\n---Testing the overloaded + operator --- adding Dylan Pan dylanpan@hotmail.com");
            Console.WriteLine(customerList.ToString());

            customerList -= p5;
            Console.WriteLine("\n---Testing the overloaded - operator --- removing Dylan Pan dylanpan@hotmail.com");
            Console.WriteLine(customerList.ToString());

            Console.WriteLine("\nPlease entry any key to continue...");
            Console.ReadLine();
        }
    }
}
