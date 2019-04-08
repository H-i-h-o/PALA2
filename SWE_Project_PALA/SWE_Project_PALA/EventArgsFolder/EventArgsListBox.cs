using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    public class EventArgsListBox : EventArgs
    {
        public List<Customer> CustList { get; private set; }

        public EventArgsListBox(List<Customer> custList)
        {
            CustList = custList;
        }
    }
}
