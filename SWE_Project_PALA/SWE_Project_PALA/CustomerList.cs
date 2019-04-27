using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SWE_Project_PALA
{
    public class CustomerList
    {
        public List<Customer> CustList = new List<Customer>();
        public event EventHandler CustomerListChangedHappened;
        public event EventHandler WriteToLogFileAvailable;
        public int MemberCounter { get; set; }

        public CustomerList()
        {
            MemberCounter = 0;
        }

        public StringBuilder PrintCustomerList()
        {
            StringBuilder CSVCustomerStringBuilder = new StringBuilder();

            foreach (Customer cust in CustList)
            {
                CSVCustomerStringBuilder.AppendLine(cust.PrintCustomerCrypt());//change to PrintCustomerCrypt() !!!
            }
            return CSVCustomerStringBuilder;
        }

        public void AddCustomer(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(EventArgsCustomerChange))
            {
                CustList.Add(((EventArgsCustomerChange)e).Cust);
                MemberCounter++;
                CustomerListChanged();
            }
        }

        public void CustomerListChanged()
        {
            CustomerListChangedHappened?.Invoke(this, new EventArgs());
        }

        public void DeleteCustomer(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(EventArgsCustomerChange))
            {
                if (((EventArgsCustomerChange) e).Cust.AccountBalance == 0)
                {
                    CustList.Remove(((EventArgsCustomerChange)e).Cust);
                    WriteToLogFileAvailable(this, new EventArgsLogFileEntryAvailable(((EventArgsCustomerChange)e).Cust.FirstName + " " + ((EventArgsCustomerChange)e).Cust.LastName + " deleted" + System.DateTime.Today.ToShortDateString()));
                    CustomerListChanged();
                }
                else
                {
                    MessageBox.Show("This customer is not able to delete due to the unsolved account balance.");
                }
            }
        }

        #region Sorting

        /// <summary>
        /// Compares the customer list by the customer NUMBER, sorts the list and returns the customer list object
        /// </summary>
        /// <returns></returns>
        public List<Customer> SortByCustomerNumber(bool descendingOrder)
        {
            CustList.Sort(CompareByCustomerNumber);
            if (descendingOrder)
            {
                CustList.Reverse();
            }
            return CustList;
        }
        private static int CompareByCustomerNumber(Customer x, Customer y)
        {
            if (x.CustomerNumber > y.CustomerNumber)
            {
                return 1;
            }
            else if (x.CustomerNumber < y.CustomerNumber)
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
        public List<Customer> SortByFirstName(bool descendingOrder)
        {
            CustList.Sort(CompareByFirstName);
            if (descendingOrder)
            {
                CustList.Reverse();
            }
            return CustList;
        }
        private static int CompareByFirstName(Customer x, Customer y)
        {
            return string.Compare(x.FirstName, y.FirstName);
        }
        /// <summary>
        /// Compares the customer list by the customer LASTNAME, sorts the list and returns the customer list object
        /// </summary>
        /// <returns></returns>
        public List<Customer> SortByLastName(bool descendingOrder)
        {
            CustList.Sort(CompareByLastName);
            if(descendingOrder)
            {
                CustList.Reverse();
            }
            return CustList;
        }
        private static int CompareByLastName(Customer x, Customer y)
        {
            return string.Compare(x.LastName, y.LastName);
        }
        /// <summary>
        /// Compares the customer list by the customer EMAIL adress, sorts the list and returns the customer list object
        /// </summary>
        /// <returns></returns>
        public List<Customer> SortByEmail(bool descendingOrder)
        {
            CustList.Sort(CompareByEmail);
            if(descendingOrder)
            {
                CustList.Reverse();
            }
            return CustList;
        }
        private static int CompareByEmail(Customer x, Customer y)
        {
            return string.Compare(x.EmailAddress.EmailAddress, y.EmailAddress.EmailAddress);
        }
        /// <summary>
        /// Compares the customer list by the customer ACCOUNT BALANCE, sorts the list and returns the customer list object
        /// </summary>
        /// <returns></returns>
        public List<Customer> SortByAccountBalance(bool descendingOrder)
        {
            CustList.Sort(CompareByAccountBalance);
            if(descendingOrder)
            {
                CustList.Reverse();
            }
            return CustList;
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
        public List<Customer> SortByLastAccess(bool descendingOrder)
        {
            CustList.Sort(CompareByLastAccess);
            if(descendingOrder)
            {
                CustList.Reverse();
            }
            return CustList;

            //CList.CustList.OrderBy(Customer => Customer.LastAccess); BETTER??? lamda expression??
        }
        private static int CompareByLastAccess(Customer x, Customer y)
        {
            return DateTime.Compare(x.LastAccess, y.LastAccess);
        }
        #endregion

        #region filtering

        /// <summary>
        /// Filters the customer list by the FIRST NAME and returns a list including all customers, which contain the searchFirstName
        /// </summary>
        /// <param name="searchFirstName"></param>
        /// <returns></returns>
        public List<Customer> FilterByFirstName(string searchFirstName)
        {
            List<Customer> FilteredList = new List<Customer>();

            foreach (Customer customer in CustList)
            {
                if (customer.FirstName.ToLower().Contains(searchFirstName.ToLower()))
                {
                    FilteredList.Add(customer);
                }
            }
            return FilteredList;
        }

        /// <summary>
        /// Filters the customer list by the FIRST NAME and returns a list including all customers, which contain the searchFirstName
        /// </summary>
        /// <param name="searchFirstName"></param>
        /// <returns></returns>
        public List<Customer> FilterByLastName(string searchLastName)
        {
            List<Customer> FilteredList = new List<Customer>();

            foreach (Customer customer in CustList)
            {
                if (customer.LastName.ToLower().Contains(searchLastName.ToLower()))
                {
                    FilteredList.Add(customer);
                }
            }
            return FilteredList;
        }

        /// <summary>
        /// Filters the customer list by the EMAIL and returns a list including all customers, which contain the searchEmail
        /// </summary>
        /// <param name="searchFirstName"></param>
        /// <returns></returns>
        public List<Customer> FilterByEmail(string searchEmail)
        {
            List<Customer> FilteredList = new List<Customer>();

            foreach (Customer customer in CustList)
            {
                if (customer.EmailAddress.EmailAddress.ToLower().Contains(searchEmail.ToLower()))
                {
                    FilteredList.Add(customer);
                }
            }
            return FilteredList;
        }

        /// <summary>
        /// Filters the customer list by the POSTAL CODE and returns a list including all customers, which contain the searchPostCode
        /// </summary>
        /// <param name="searchFirstName"></param>
        /// <returns></returns>
        public List<Customer> FilterByPostCode(string searchPostCode)
        {
            List<Customer> FilteredList = new List<Customer>();

            foreach (Customer customer in CustList)
            {
                if (customer.CustAdresse.PostCode.ToString().ToLower().Contains(searchPostCode.ToLower()))
                {
                    FilteredList.Add(customer);
                }
            }
            return FilteredList;
        }

        /// <summary>
        /// Filters the customer list by the CITY and returns a list including all customers, which contain the searchCity
        /// </summary>
        /// <param name="searchFirstName"></param>
        /// <returns></returns>
        public List<Customer> FilterByCity(string searchCity)
        {
            List<Customer> FilteredList = new List<Customer>();

            foreach (Customer customer in CustList)
            {
                if (customer.CustAdresse.City.ToLower().Contains(searchCity.ToLower()))
                {
                    FilteredList.Add(customer);
                }
            }
            return FilteredList;
        }

        #endregion
    }
}
