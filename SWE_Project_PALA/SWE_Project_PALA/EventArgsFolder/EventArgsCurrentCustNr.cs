using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA.EventArgsFolder
{
    public class EventArgsCurrentCustNr : EventArgs
    {
        public int CurrentCustNr;

        public EventArgsCurrentCustNr(int currentCustNr)
        {
            CurrentCustNr = currentCustNr;
        }
    }
}
