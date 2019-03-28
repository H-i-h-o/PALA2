using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    public class CustomerSorter
    {
        private CustomerList CList;

        //IMPORTANT: probaplay also list.OrderBy() and list.OrderByDescending possible

        public CustomerSorter(CustomerList CList)
        {
            this.CList = CList;
        }
        /// <summary>
        /// Compares the customer list by the customer NUMBER, sorts the list and returns the customer list object
        /// </summary>
        /// <returns></returns>
        public CustomerList SortByCustomerNumber()
        {
            CList.CustList.Sort(CompareByCustomerNumber);
            return CList;
        }
        private static int CompareByCustomerNumber(Customer x, Customer y)
        {
            if(x.CustomerNumber > y.CustomerNumber)
            {
                return 1;
            }
            else if(x.CustomerNumber < y.CustomerNumber)
            {
                return -1;
            }
            else
            {
                //theoretically not possible but:
                return 0;
            }
        }
        /// <summary>
        /// Compares the customer list by the customer FIRSTNAME, sorts the list and returns the customer list object
        /// </summary>
        /// <returns></returns>
        public CustomerList SortByFirstName()
        {
            CList.CustList.Sort(CompareByFirstName);
            return CList;
        }
        private static int CompareByFirstName(Customer x, Customer y)
        {
            return string.Compare(x.FirstName, y.FirstName);
        }
        /// <summary>
        /// Compares the customer list by the customer LASTNAME, sorts the list and returns the customer list object
        /// </summary>
        /// <returns></returns>
        public CustomerList SortByLastName()
        {
            CList.CustList.Sort(CompareByLastName);
            return CList;
        }
        private static int CompareByLastName(Customer x, Customer y)
        {
            return string.Compare(x.LastName, y.LastName);
        }
        /// <summary>
        /// Compares the customer list by the customer EMAIL adress, sorts the list and returns the customer list object
        /// </summary>
        /// <returns></returns>
        public CustomerList SortByEmail()
        {
            CList.CustList.Sort(CompareByEmail);
            return CList;
        }
        private static int CompareByEmail(Customer x, Customer y)
        {
            return string.Compare(x.EmailAddress.EmailAddress, y.EmailAddress.EmailAddress);
        }
        /// <summary>
        /// Compares the customer list by the customer ACCOUNT BALANCE, sorts the list and returns the customer list object
        /// </summary>
        /// <returns></returns>
        public CustomerList SortByAccountBalance()
        {
            CList.CustList.Sort(CompareByAccountBalance);
            return CList;
        }
        private static int CompareByAccountBalance(Customer x, Customer y)
        {
            if (x.AccountBalance > y.AccountBalance)
            {
                return 1;
            }
            else if (x.AccountBalance < y.AccountBalance)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Compares the customer list by the customer LAST ACCESS, sorts the list and returns the customer list object
        /// </summary>
        /// <returns></returns>
        public CustomerList SortByLastAccess()
        {
            CList.CustList.Sort(CompareByLastAccess);
            //CList.CustList.OrderBy(Customer => Customer.LastAccess); BETTER??? lamda expression??
            return CList;
        }
        private static int CompareByLastAccess(Customer x, Customer y)
        {
            return DateTime.Compare(x.LastAccess, y.LastAccess);
        }
        /// <summary>
        /// Filters the customer list by the FIRST NAME and returns all customers, which contain the searchFirstName
        /// </summary>
        /// <param name="searchFirstName"></param>
        /// <returns></returns>
        public CustomerList FilterByFirstName(string searchFirstName)
        {
            foreach (Customer customer in CList.CustList)
            {
                if (!customer.FirstName.ToLower().Contains(searchFirstName.ToLower()))
                {
                    CList.CustList.Remove(customer);
                }
            }
            return CList;
        }
        /// <summary>
        /// Filters the customer list by the LAST NAME and returns all customers, which contain the searchLastName
        /// </summary>
        /// <param name="searchFirstName"></param>
        /// <returns></returns>
        public CustomerList FilterByLastName(string searchLastName)
        {
            foreach(Customer customer in CList.CustList)
            {
                if (!customer.LastName.ToLower().Contains(searchLastName.ToLower()))
                {
                    CList.CustList.Remove(customer);
                }
            }
            return CList;
        }
        /// <summary>
        /// Filters the customer list by the EMAIL ADRESS and returns all customers, which contain the searchEmail
        /// </summary>
        /// <param name="searchEmail"></param>
        /// <returns></returns>
        public CustomerList FilterByEmail(string searchEmail)
        {
            foreach (Customer customer in CList.CustList)
            {
                if (!customer.EmailAddress.EmailAddress.ToLower().Contains(searchEmail.ToLower()))
                {
                    CList.CustList.Remove(customer);
                }
            }
            return CList;
        }

    }
}
