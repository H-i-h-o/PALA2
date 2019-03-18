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

        public CSVHandling()
        {
        }

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

        public static CustomerList LoadCustomerListFromCSV(string path)
        {
            StreamReader SReader = new StreamReader(path);
            CustomerList CustList = new CustomerList();

            try
            {
                while (SReader.Peek() != -1)
                {
                    CustList.CustList.Add(Customer.parseCustomer(SReader.ReadLine()));
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
