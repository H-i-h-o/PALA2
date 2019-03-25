using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    public class Crypto
    {
        private static string ShiftString(string Input, int Shift)
        {
            string Output = string.Empty;

            foreach (char character in Input)
            {
                Output += Convert.ToChar(Convert.ToInt32(character) + Shift);
            }

            return Output;
        }
        
        public static string EncodeLine(string [] input)
        {
            string EncodedLine = string.Empty;

            foreach (string str in input)
            {
                EncodedLine += ShiftString(str, 1) + ";";
            }
            
            return EncodedLine;
        }
        public static string[] DecodeLine(string input)
        {
            string[] Columns = input.Split(';');
            //Columns.Take(Columns.Length-1).Skip(1).ToArray();
            string[] output = new string[Columns.Length-1];

            for (int i = 0; i < Columns.Length-1; i++)
            {
                output[i] = ShiftString(Columns[i], -1);
            }

            return output;
        }
        //private static string Encode2(string input)
        //{

        //    return "";
        //}
        //private static string Decode2(string input)
        //{

        //    return "";
        //}


    }
}
