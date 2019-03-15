using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    public class CustomerList
    {
        public List<Customer> CustList;

        public CustomerList()
        {
            
        }

        public StringBuilder PrintCustomerList()
        {
            StringBuilder CSVCustomerStringBuilder = new StringBuilder();

            foreach (Customer cust in CustList)
            {
                CSVCustomerStringBuilder.AppendLine(cust.PrintCustomer());
            }
            return CSVCustomerStringBuilder;
        }

        public void AddCustomer(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(EventArgsNewCustomer))
            {
                CustList.Add(((EventArgsNewCustomer)e).NewCustomer);
            }
        }

        public void EditCustomer(object sender, EventArgs e)
        {
               
        }




    }
}
