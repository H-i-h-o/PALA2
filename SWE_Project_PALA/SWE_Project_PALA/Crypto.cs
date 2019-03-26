using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    /// <summary>
    /// The static class Crypt can be used to encode or decode lines of a csv-file
    /// </summary>
    static public class Crypto
    {
        /// <summary>
        /// Shifts each character of the Input by Shift
        /// </summary>
        /// <param name="Input"></param>
        /// <param name="Shift"></param>
        /// <returns></returns>
        private static string ShiftString(string Input, int Shift)
        {
            string Output = string.Empty;

            foreach (char character in Input)
            {
                Output += Convert.ToChar(Convert.ToInt32(character) + Shift);
            }

            return Output;
        }

        /// <summary>
        /// Encodes all elements of input by applying a shift to each character of the strings, 
        /// appends a semiconol to each string and concatenates the strings
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string EncodeLine(string [] input)
        {
            string EncodedLine = string.Empty;

            foreach (string str in input)
            {
                EncodedLine += ShiftString(str, 1) + ";";
            }
            
            return EncodedLine;
        }

        /// <summary>
        /// Splits the input (line from a csv-file), decodes the elments and returns the decoded elements
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
    }
}
