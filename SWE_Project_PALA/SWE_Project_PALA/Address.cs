using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    /// <summary>
    /// Class Address
    /// new type address, possible to put to string or csv code after implementation
    /// saves lines of code during implementation of customer
    /// </summary>
    public class Address
    {
        public string Street { private set; get; }
        public string StreetNr { private set; get; }
        public string City { private set; get; }
        public int PostCode { private set; get; }

        public Address(string street, string streetNr, int postCode, string city)
        {
            Street = street.Trim();
            StreetNr = streetNr;
            PostCode = postCode;
            City = city.Trim();
        }
        /*special constructor for the loading of a customer address from a csv file to save code
         */
        public Address(string streetAndStreetNrAndpostCodeAndCity)
        {
            string[] address = streetAndStreetNrAndpostCodeAndCity.Split(';');
            if (address.Length == 4)
            {
                Street = address[0];
                StreetNr = address[1];
                PostCode = Convert.ToInt32(address[2]);
                City = address[3];
            }
        }

        public string ToCSVString()
        {
            return Street + "; " + StreetNr + "; " + PostCode + "; " + City;
        }

        public override string ToString()
        {
            return Street + " " + StreetNr + ", " + PostCode + ", " + City;

        }
    }
}
