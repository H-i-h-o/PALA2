using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Project_PALA
{
    public partial class Form1 : Form
    {
        public CustomerList CustList = new CustomerList();
        private static readonly string PathCList = Application.StartupPath + "\\CList_crypted.csv";
        private static readonly string PathLoginLogFile = Application.StartupPath + "\\LoginLogFile.csv";
        private static readonly string PathCustomerDeleteLogFile = Application.StartupPath + "\\CustomerDeleteLogFile.csv";


        public Form1()
        {

            InitializeComponent();

            CustList = LoadCustomList();
            CustList.CustomerListChangedHappened += new EventHandler(RefreshListBox);
            CustList.WriteToLogFileAvailable += new EventHandler(HandleLogFiles);

            CustList.CustomerListChanged();


            //CustList = LoadCustomList();
            //RefreshListBox(null, null);


        }

        // das könnte wahrscheinlich probleme verursachen...
        public static void HandleLogFiles(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(EventArgsLogFileEntryAvailable))
            {
                //if (((EventArgsLogFileEntryAvailable)sender).GetType() == typeof(PasswordForm))
                if (sender.GetType() == typeof(PasswordForm))
                {
                    CSVHandling.StringToCSV(((EventArgsLogFileEntryAvailable)e).StringToWrite, PathCustomerDeleteLogFile);
                }
                else if (sender.GetType() == typeof(Program))
                {
                    CSVHandling.StringToCSV(((EventArgsLogFileEntryAvailable)e).StringToWrite, PathLoginLogFile);
                }
            }
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            CustomerForm CustForm = new CustomerForm(this);
            CustForm.NewCustomerAvailable += new EventHandler(CustList.AddCustomer);

            CustForm.Show();
        }

        public int GetNewCustomerNumber()
        {
            return CustList.CustList.Count() + 1;
        }

        public void RefreshListBox(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(EventArgsListBox))
            {
                listBox1.Items.Clear();
                foreach (Customer Cust in ((EventArgsListBox)e).CustList)
                {
                    listBox1.Items.Add(Cust);
                }
                btn_Edit.Enabled = false;
                SaveCustomList();
            }
            else
            {
                listBox1.Items.Clear();
                foreach (Customer Cust in (CustList.CustList))
                {
                    listBox1.Items.Add(Cust);
                }
                btn_Edit.Enabled = false;
                SaveCustomList();
            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            object selectedItem = listBox1.SelectedItem;
            if (selectedItem.GetType() == typeof(Customer))
            {
                CustomerBalanceForm custBalanceForm = new CustomerBalanceForm(this, (Customer)selectedItem);
                custBalanceForm.Show();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                object selectedItem = listBox1.SelectedItem;
                if (selectedItem.GetType() == typeof(Customer))
                {
                    CustomerForm CustForm = new CustomerForm(((Customer) selectedItem), this);
                    CustForm.NewCustomerAvailable += new EventHandler(CustList.AddCustomer);
                    CustForm.CustomerDeleteAvailable += new EventHandler(CustList.DeleteCustomer);

                    CustForm.Show();
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                btn_Edit.Enabled = true;
            }
        }

        private void SaveCustomList()
        {
            CSVHandling.SaveCustomerListToCSV(CustList, PathCList);
        }

        private CustomerList LoadCustomList()
        {
            if (File.Exists(PathCList))
            {
                return CSVHandling.LoadCustomerListFromCSV(PathCList);
            }
            else
            {
                return new CustomerList();
            }
        }

        private void SFButton_Click(object sender, EventArgs e)
        {
            //code for connecting the sort and filter form with the functionality of the customer list
            CustomerList SubList = new CustomerList();

            SortingAndFilteringForm SFForm = new SortingAndFilteringForm();
            
            if(SFForm.ShowDialog() == DialogResult.OK)
            {
                if(SFForm.SortList)
                {
                    switch (SFForm.SortBy)
                    {
                        case "Cusomer number":
                            SubList.CustList = CustList.SortByCustomerNumber(SFForm.SortDescending);
                            break;

                        case "First name":
                            SubList.CustList = CustList.SortByFirstName(SFForm.SortDescending);
                            break;

                        case "Last name":
                            SubList.CustList = CustList.SortByLastName(SFForm.SortDescending);
                            break;

                        case "Email":
                            SubList.CustList = CustList.SortByEmail(SFForm.SortDescending);
                            break;

                        case "Account balance":
                            SubList.CustList = CustList.SortByAccountBalance(SFForm.SortDescending);
                            break;

                        case "Last Access":
                            SubList.CustList = CustList.SortByLastAccess(SFForm.SortDescending);
                            break;
                    }
                }
                //what to do with sublist?? does it overwrite the whole customer list??
                if(SFForm.FilterList)
                {
                    //code for filtering the list
                }

                RefreshListBox(this, new EventArgsListBox(SubList.CustList));
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                object selectedItem = listBox1.SelectedItem;
                if (selectedItem.GetType() == typeof(Customer))
                {
                    CustList.DeleteCustomer(this, new EventArgsCustomerChange((Customer)selectedItem));
                }
            }
        }
    }
}
