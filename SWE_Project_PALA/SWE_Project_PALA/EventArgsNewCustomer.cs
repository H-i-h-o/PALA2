using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    public class EventArgsNewCustomer: EventArgs
    {
        public Customer NewCustomer;

        public EventArgsNewCustomer(Customer newCustomer)
        {
            NewCustomer = newCustomer;
        }
    }
}
