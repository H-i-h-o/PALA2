using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
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

        public Address(string streetAndStreetNrAndpostCodeAndCity)
        {
            string[] adress = streetAndStreetNrAndpostCodeAndCity.Split(';');
            if (adress.Length == 4)
            {
                Street = adress[0];
                StreetNr = adress[1];
                PostCode = Convert.ToInt32(adress[2]);
                City = adress[3];
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
