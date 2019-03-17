using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    public class Crypto
    {
        public static string Encode(string input)
        {
            int Shift = 50;
            string Output = string.Empty;

            foreach (char character in input)
            {
                Output += Convert.ToChar(Convert.ToInt32(character) + Shift);
            }

            return Output;
        }
        public static string Decode(string input)
        {
            int Shift = -50;
            string Output = string.Empty;

            foreach (char character in input)
            {
                Output += Convert.ToChar(Convert.ToInt32(character) + Shift);
            }

            return Output;
        }
    }
}
