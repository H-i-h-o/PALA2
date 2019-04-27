using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWE_Project_PALA.EventArgsFolder;

namespace SWE_Project_PALA
{
    /// <summary>
    /// The static class CSVHanlding can be used to save or load a customer list
    /// </summary>
    static public class CSVHandling
    {
        public static event EventHandler  CurrentCustNrAvailable;
        /// <summary>
        /// Saves all items of custlist encoded to csv-file at path
        /// </summary>
        /// <param name="custList"></param>
        /// <param name="path"></param>
        public static void SaveCustomerListToCSV(int CurrentCustNr, CustomerList custList, string path)
        {
            StreamWriter SWriter = null;

            try
            {
                SWriter = new StreamWriter(path) {AutoFlush = true};
                SWriter.WriteLine(CurrentCustNr);
                SWriter.Write(custList.PrintCustomerList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("A error occured: the customer list could not be saved!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                if(SWriter != null)
                {
                    SWriter.Close();
                }
            }
        }

        /// <summary>
        /// Loads all lines from the csv-file with path; parses a Customer for each line and returns all Customers in a CustomerList
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static CustomerList LoadCustomerListFromCSV(string path)
        {
            StreamReader SReader = null;
            CustomerList CustList = new CustomerList();

            try
            {
                SReader = new StreamReader(path);
                CustList.MemberCounter = Convert.ToInt32(SReader.ReadLine());
                CurrentCustNrAvailable("LoadedList", new EventArgsCurrentCustNr(CustList.MemberCounter));

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
                if (SReader != null)
                {
                    SReader.Close();
                }
            }
        }

        /// <summary>
        /// Saves a string line to a csv file
        /// </summary>
        /// <param name="custList"></param>
        /// <param name="path"></param>
        public static void StringToCSV(string sringToWrite, string path)
        {
            StreamWriter SWriter = null;
            try
            {
                SWriter = new StreamWriter(path) {AutoFlush = true};

                SWriter.Write(sringToWrite);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A error occurred: the log file could not be saved!" + Environment.NewLine +
                                ex.Message);
            }
            finally
            {
                if (SWriter != null)
                {
                    SWriter.Close();
                }
            }
        }
    }
}
