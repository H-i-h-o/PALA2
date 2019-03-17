using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    public class Customer
    {
        public string FirstName { private set;  get; }
        public string LastName { private set; get; }
        public Email EmailAddress { private set; get; }
        public int CustomerNumber { private set; get; }
        public int AccountBalance { private set; get; }
        public DateTime LastAccess { private set; get; }

        public Customer(string firstName, string lastName, string emailAddress, int customerNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = new Email(emailAddress);
            AccountBalance = 0;
            LastAccess = DateTime.Today;
            CustomerNumber = customerNumber;
        }
        public Customer(string firstName, string lastName, string emailAddress, int customerNumber, DateTime lastAccess)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = new Email(emailAddress);
            AccountBalance = 0;
            LastAccess = lastAccess;
            CustomerNumber = customerNumber;
        }

        public static Customer parsePerson(string text)
        {
            string[] parts = text.Split(';');
            return new Customer(parts[1], parts[2], parts[3], Convert.ToInt32(parts[0]), Convert.ToDateTime(parts[4]));
        }

        public void ChangeToAccountBalance(int expense)
        {
            AccountBalance = AccountBalance + expense;
            LastAccessChanged();
        }

        public void LastAccessChanged()
        {
            LastAccess = DateTime.Today;
        }

        public string PrintCustomer()
        {
            return CustomerNumber + ";" + FirstName + ", " + LastName + ", " + EmailAddress.Print() + ", " + AccountBalance + ", " + LastAccess.ToShortDateString();
        }

        public void ChangeName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void ChangeEmail(string emailAddress)
        {
            EmailAddress.ChangeEmail(emailAddress);
        }

        public override string ToString()
        {
            return CustomerNumber + "   " + FirstName + "   " + LastName + "    " + EmailAddress.Print() + "    " + AccountBalance + "  " + LastAccess.ToShortDateString();
        }
    }
}

