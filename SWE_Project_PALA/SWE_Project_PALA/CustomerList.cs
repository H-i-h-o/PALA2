using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SWE_Project_PALA
{
    public class CustomerList
    {
        public List<Customer> CustList = new List<Customer>();
        public event EventHandler CustomerListChangedHappened;

        public CustomerList()
        {
            
        }

        public StringBuilder PrintCustomerList()
        {
            StringBuilder CSVCustomerStringBuilder = new StringBuilder();

            foreach (Customer cust in CustList)
            {
                CSVCustomerStringBuilder.AppendLine(cust.PrintCustomer());
            }
            return CSVCustomerStringBuilder;
        }

        public void AddCustomer(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(EventArgsNewCustomer))
            {
                CustList.Add(((EventArgsNewCustomer)e).NewCustomer);
                CustomerListChanged();
            }
        }

        private void CustomerListChanged()
        {
            CustomerListChangedHappened?.Invoke(this, new EventArgs());
        }

        //private void SaveCustomerListToCSV(string Path)
        //{
        //    StreamWriter SWriter = new StreamWriter(Path);

        //    try
        //    {
        //        SWriter.Write(PrintCustomerList());
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("A error occured: the customer list could not be saved!" + Environment.NewLine + ex.Message);
        //    }
        //    finally
        //    {
        //        SWriter.Close();
        //    }
        //}

        //private void LoadCustomerListFromCSV(string Path)
        //{
        //    StreamReader SReader = new StreamReader(Path);
        //    CustList.Clear(); //ACHTUNG evtl Fehler

        //    try
        //    {
        //        while(SReader.Peek() != -1)
        //        {
        //            CustList.Add(Customer.parsePerson(SReader.ReadLine()));
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("A error occured: the customer list could not be loaded!" + Environment.NewLine + ex.Message);
        //    }
        //    finally
        //    {
        //        SReader.Close();
        //    }
        //}
    }
}
