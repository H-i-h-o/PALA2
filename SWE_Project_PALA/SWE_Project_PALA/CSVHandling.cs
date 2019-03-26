using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Project_PALA
{
    public class CSVHandling
    {
        /// <summary>
        /// Saves all items of custlist encoded to csv-file at path
        /// </summary>
        /// <param name="custList"></param>
        /// <param name="path"></param>
        public static void SaveCustomerListToCSV(CustomerList custList, string path)
        {
            StreamWriter SWriter = new StreamWriter(path);

            try
            {
                SWriter.Write(custList.PrintCustomerList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("A error occured: the customer list could not be saved!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                SWriter.Close();
            }
        }

        /// <summary>
        /// Loads all lines from the csv-file with path, parses a Customer for each line and returns all Customers in a CustomerList
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static CustomerList LoadCustomerListFromCSV(string path)
        {
            StreamReader SReader = new StreamReader(path);
            CustomerList CustList = new CustomerList();

            try
            {
                while (SReader.Peek() != -1)
                {
                    CustList.CustList.Add(Customer.ParseAndDecryptCustomer(SReader.ReadLine()));//change to ParseAndDecryptCustomer!!
                }
                return CustList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("A error occured: the customer list could not be loaded!" + Environment.NewLine + ex.Message);
                return CustList;
            }
            finally
            {
                SReader.Close();
            }
        }
    }
}
