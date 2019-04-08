using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    public class EventArgsCustomerChange: System.EventArgs
    {
        public Customer Cust;

        public EventArgsCustomerChange(Customer cust)
        {
            Cust = cust;
        }
    }
}
