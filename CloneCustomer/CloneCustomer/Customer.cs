using System;

namespace CloneCustomer
{
    // For Lab 8
    public class Customer : ICloneable, IComparable<Customer>
	{
		private string firstName;
		private string lastName;
		private string email;

		public Customer()
		{
		}

		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
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
			{
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
				email = value;
			}
		}

		public string GetDisplayText()
		{
			return firstName + " " + lastName + ", " + email;
		}

        public object Clone()
        {
            // three different ways to pass variables for clone, below is example
            Customer c = new Customer(this.FirstName, LastName, email);
            return c;
        }

        public override string ToString()
        {
            return lastName + ", " + firstName + ", " + email;
        }

        // compare two customers by ToString() customer's info 
        public int CompareTo(Customer other)
        {
            return this.ToString().CompareTo(other.ToString());
        }
    }
}
