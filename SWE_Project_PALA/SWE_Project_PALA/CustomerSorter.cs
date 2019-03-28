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

        public CustomerSorter(CustomerList CList)
        {
            this.CList = CList;
        }

        public CustomerList SortByFirstName()
        {
            CList.CustList.Sort(CompareByFirstName);

            return CList;
        }
        private static int CompareByFirstName(Customer x, Customer y)
        {
            return string.Compare(x.FirstName, y.FirstName);
        }
        public CustomerList SortByLastName()
        {
            CList.CustList.Sort(CompareByLastName);

            return CList;
        }
        private static int CompareByLastName(Customer x, Customer y)
        {
            return string.Compare(x.LastName, y.LastName);
        }


    }
}
