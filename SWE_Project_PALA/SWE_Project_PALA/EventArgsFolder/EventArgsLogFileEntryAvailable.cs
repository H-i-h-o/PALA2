using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    public class EventArgsLogFileEntryAvailable : System.EventArgs
    {
        public string StringToWrite { get; private set; }
        public string Source { get; private set; }

        public EventArgsLogFileEntryAvailable(string stringToWrite, string source)
        {
            StringToWrite = stringToWrite;
            Source = source;
        }

        public EventArgsLogFileEntryAvailable(string stringToWrite)
        {
            StringToWrite = stringToWrite;
        }
    }
}
