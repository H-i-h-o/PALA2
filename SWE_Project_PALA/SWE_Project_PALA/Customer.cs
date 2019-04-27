using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Address CustAdresse { private set; get; }

        #region Constructor

        public Customer(int customerNumber, string firstName, string lastName, Email emailAddress, Address custAdresse)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            AccountBalance = 0;
            LastAccess = DateTime.Today;
            CustomerNumber = customerNumber;
            CustAdresse = custAdresse;
        }
        public Customer(int customerNumber, string firstName, string lastName, string emailAddress, Address custAdresse, DateTime lastAccess)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = new Email(emailAddress);
            AccountBalance = 0;
            LastAccess = lastAccess;
            CustomerNumber = customerNumber;
            CustAdresse = custAdresse;
        }
        public Customer(int customerNumber, string firstName, string lastName, string emailAddress, Address custAdresse, DateTime lastAccess, int accountBalance)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = new Email(emailAddress);
            AccountBalance = accountBalance;
            LastAccess = lastAccess;
            CustomerNumber = customerNumber;
            CustAdresse = custAdresse;

        }
        public Customer(ListViewItem.ListViewSubItemCollection customerInfoArray)
        {
            CustomerNumber = Convert.ToInt32(customerInfoArray[0]);
            FirstName = customerInfoArray[1].Text;
            LastName = customerInfoArray[2].Text;
            EmailAddress = new Email(customerInfoArray[3].Text);
            AccountBalance = Convert.ToInt32(customerInfoArray[4].Text);
            LastAccess = DateTime.Parse(customerInfoArray[5].Text);
            CustAdresse = new Address(customerInfoArray[8].Text, customerInfoArray[9].Text, Convert.ToInt32(customerInfoArray[6].Text), customerInfoArray[7].Text);

        }
        #endregion

        public static Customer parseCustomer(string text)
        {
            string[] parts = text.Split(';');
            return new Customer(int.Parse(parts[0]), parts[1], parts[2], parts[3], new Address(parts[4]), DateTime.Parse(parts[5]), int.Parse(parts[6]));
        }   

        public static Customer ParseAndDecryptCustomer(string text)
        {
            string[] parts = Crypto.DecodeLine(text);

            return new Customer(int.Parse(parts[0]), parts[1], parts[2], parts[3], new Address(parts[4]), DateTime.Parse(parts[5]),int.Parse(parts[6]));
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

        public string PrintCustomerForView()
        {
            return CustomerNumber + "," + FirstName + "," + LastName + "," + EmailAddress.Print() + "," + AccountBalance + "," + LastAccess.ToShortDateString() + "," + CustAdresse.ToCSVString();
        }

        public string PrintCustomerCrypt()
        {
            return Crypto.EncodeLine(new string[] { CustomerNumber.ToString(), FirstName, LastName, EmailAddress.Print(), CustAdresse.ToCSVString(), LastAccess.ToShortDateString(), AccountBalance.ToString() });
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

        public void ChangeAdresse(Address custAdresse)
        {
            CustAdresse = custAdresse;
        }

        public override string ToString()
        {
            return CustomerNumber + ", " + FirstName + ", " + LastName + ", " + EmailAddress.Print() + ", " + CustAdresse.ToString() + ", " + LastAccess.ToShortDateString() + ", " + AccountBalance;
        }

        //            return Crypto.EncodeLine(new string[] { CustomerNumber.ToString(), FirstName, LastName, EmailAddress.Print(), CustAdresse.ToCSVString(), LastAccess.ToShortDateString(), AccountBalance.ToString() });
        public string[] GetListViewItemRange()
        {
            string[] arr = new string[11]
            {
                CustomerNumber.ToString(), FirstName, LastName, EmailAddress.Print(), AccountBalance.ToString(), CustAdresse.PostCode.ToString(),CustAdresse.City,CustAdresse.Street,CustAdresse.StreetNr.ToString(),
                LastAccess.ToShortDateString(),""
            };
            return arr;
        }
    }
}

