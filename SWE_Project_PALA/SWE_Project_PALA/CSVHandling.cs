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
        
        // gives the possibility to get the event to set the Current Customer Number from the CSV List
        public static event EventHandler  CurrentCustNrAvailable;

        /// <summary>
        /// Saves all items of custlist encoded to csv-file with the given path
        /// the csv file consists in the first line of the current customer number 
        /// followed by each customer encrypted and transferred to the csv format in the class CustomerList
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
        /// Loads all lines from the csv-file with path; parses and decrypt a Customer for each line and returns all Customers in a CustomerList
        /// it sets the current customer number of the customer list to the value saved in the first line of the csv line and releases a event in case someone wants to get it too
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
                //first line is reserved for the current customer number of the last time, it is then set up the current number of the customerlist and released the event
                CustList.MemberCounter = Convert.ToInt32(SReader.ReadLine());
                CurrentCustNrAvailable("LoadedList", new EventArgsCurrentCustNr(CustList.MemberCounter));

                while (SReader.Peek() != -1)
                {
                    //reads the file to the end, decrypt and adds the customer to the customer list
                    CustList.CustList.Add(Customer.ParseAndDecryptCustomer(SReader.ReadLine()));
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
        /// used to generate Log files or other csv documents
        /// string and path needed
        /// </summary>
        /// <param name="stringToWrite"></param>
        /// <param name="path"></param>
        public static void StringToCSV(string stringToWrite, string path)
        {
            StreamWriter SWriter = null;
            try
            {
                SWriter = new StreamWriter(path) {AutoFlush = true};

                SWriter.Write(stringToWrite);
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
