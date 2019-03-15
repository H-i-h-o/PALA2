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
        public int AccountBalance { private set; get; }
        public DateTime LastAccess { private set; get; }

        public Customer(string firstName, string lastName, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = new Email(emailAddress);
            AccountBalance = 0;
            LastAccess = DateTime.Today;
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
            return FirstName + ", " + LastName + ", " + EmailAddress.Print() + ", " + AccountBalance + ", " + LastAccess.ToShortDateString();
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


    }
}

