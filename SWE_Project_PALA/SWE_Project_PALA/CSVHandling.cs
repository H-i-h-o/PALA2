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
        private CustomerList CustList = new CustomerList();

        public CSVHandling(CustomerList custList)
        {
            CustList = custList;
        }

        private void SaveCustomerListToCSV(string Path)
        {
            StreamWriter SWriter = new StreamWriter(Path);

            try
            {
                SWriter.Write(CustList.PrintCustomerList());
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

        private void LoadCustomerListFromCSV(string Path)
        {
            StreamReader SReader = new StreamReader(Path);
            CustList.CustList.Clear(); //ACHTUNG evtl Fehler

            try
            {
                while (SReader.Peek() != -1)
                {
                    CustList.CustList.Add(Customer.parsePerson(SReader.ReadLine()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A error occured: the customer list could not be loaded!" + Environment.NewLine + ex.Message);
            }
            finally
            {
                SReader.Close();
            }
        }
    }
}
