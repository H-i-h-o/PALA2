using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    public class Adresse
    {
        public string Street { private set; get; }
        public string StreetNr { private set; get; }
        public string City { private set; get; }
        public int PostCode { private set; get; }

        public Adresse(string street, string streetNr, int postCode, string city)
        {
            Street = street;
            StreetNr = streetNr;
            PostCode = postCode;
            City = city;
        }

        public override string ToString()
        {
            return Street + "; " + StreetNr + "; " + PostCode + "; " + City;
        }
    }
}
