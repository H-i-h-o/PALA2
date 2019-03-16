using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    class Crypto
    {
        public static string Encode(string Input)
        {
            int Shift = 50;
            string Output = string.Empty;

            foreach (char character in Input)
            {
                Output += Convert.ToChar(Convert.ToInt32(character) + Shift);
            }

            return Output;
        }
        public static string Decode(string Input)
        {
            int Shift = -50;
            string Output = string.Empty;

            foreach (char character in Input)
            {
                Output += Convert.ToChar(Convert.ToInt32(character) + Shift);
            }

            return Output;
        }
    }
}
