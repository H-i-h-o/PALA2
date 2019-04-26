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

            DataGridViewCustomer.MultiSelect = false;
            DataGridViewCustomer.Columns.Add("0", "Customer Number");
            DataGridViewCustomer.Columns.Add("1", "First Name");
            DataGridViewCustomer.Columns.Add("2", "Last Name");
            DataGridViewCustomer.Columns.Add("3", "E-Mail Address");
            DataGridViewCustomer.Columns.Add("4", "Open Balance [€]");
            DataGridViewCustomer.Columns.Add("5", "Last Change");
            DataGridViewCustomer.Columns.Add("6", "Post Code");
            DataGridViewCustomer.Columns.Add("7", "City");
            DataGridViewCustomer.Columns.Add("8", "Street");
            DataGridViewCustomer.Columns.Add("9", "Nr.");
            DataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DataGridViewCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridViewCustomer.ColumnHeadersDefaultCellStyle.Font =
                new Font(DataGridViewCustomer.Font, FontStyle.Bold);

            CustList.CustomerListChanged();

            //DataGridViewCustomer.Rows[number].Cells[0].Value = Cust.CustomerNumber;
            //DataGridViewCustomer.Rows[number].Cells[1].Value = Cust.FirstName;
            //DataGridViewCustomer.Rows[number].Cells[2].Value = Cust.LastName;
            //DataGridViewCustomer.Rows[number].Cells[3].Value = Cust.EmailAddress;
            //DataGridViewCustomer.Rows[number].Cells[4].Value = Cust.AccountBalance;
            //DataGridViewCustomer.Rows[number].Cells[5].Value = Cust.LastAccess;
            //DataGridViewCustomer.Rows[number].Cells[6].Value = Cust.CustAdresse.PostCode;
            //DataGridViewCustomer.Rows[number].Cells[7].Value = Cust.CustAdresse.City;
            //DataGridViewCustomer.Rows[number].Cells[8].Value = Cust.CustAdresse.Street;
            //DataGridViewCustomer.Rows[number].Cells[9].Value = Cust.CustAdresse.StreetNr;

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
                DataGridViewCustomer.Rows.Clear();

                foreach (Customer Cust in ((EventArgsListBox)e).CustList)
                {
                    listBox1.Items.Add(Cust);

                    //DataGridViewCustomer.Rows.Add(Cust.ToString());
                    int number = DataGridViewCustomer.Rows.Add();
                    DataGridViewCustomer.Rows[number].Cells[0].Value = Cust.CustomerNumber;
                    DataGridViewCustomer.Rows[number].Cells[1].Value = Cust.FirstName;
                    DataGridViewCustomer.Rows[number].Cells[2].Value = Cust.LastName;
                    DataGridViewCustomer.Rows[number].Cells[3].Value = Cust.EmailAddress.EmailAddress;
                    DataGridViewCustomer.Rows[number].Cells[4].Value = Cust.AccountBalance;
                    DataGridViewCustomer.Rows[number].Cells[5].Value = Cust.LastAccess;
                    DataGridViewCustomer.Rows[number].Cells[6].Value = Cust.CustAdresse.PostCode;
                    DataGridViewCustomer.Rows[number].Cells[7].Value = Cust.CustAdresse.City;
                    DataGridViewCustomer.Rows[number].Cells[8].Value = Cust.CustAdresse.Street;
                    DataGridViewCustomer.Rows[number].Cells[9].Value = Cust.CustAdresse.StreetNr;
                }
                btn_Edit.Enabled = false;
                SaveCustomList();
            }
            else
            {
                listBox1.Items.Clear();
                DataGridViewCustomer.Rows.Clear();

                foreach (Customer Cust in (CustList.CustList))
                {
                    listBox1.Items.Add(Cust);

                    //DataGridViewCustomer.Rows.Add(Cust.ToString());
                    int number = DataGridViewCustomer.Rows.Add();
                    DataGridViewCustomer.Rows[number].Cells[0].Value = Cust.CustomerNumber;
                    DataGridViewCustomer.Rows[number].Cells[1].Value = Cust.FirstName;
                    DataGridViewCustomer.Rows[number].Cells[2].Value = Cust.LastName;
                    DataGridViewCustomer.Rows[number].Cells[3].Value = Cust.EmailAddress.EmailAddress;
                    DataGridViewCustomer.Rows[number].Cells[4].Value = Cust.AccountBalance;
                    DataGridViewCustomer.Rows[number].Cells[5].Value = Cust.LastAccess;
                    DataGridViewCustomer.Rows[number].Cells[6].Value = Cust.CustAdresse.PostCode;
                    DataGridViewCustomer.Rows[number].Cells[7].Value = Cust.CustAdresse.City;
                    DataGridViewCustomer.Rows[number].Cells[8].Value = Cust.CustAdresse.Street;
                    DataGridViewCustomer.Rows[number].Cells[9].Value = Cust.CustAdresse.StreetNr;
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
            if (DataGridViewCustomer.CurrentCell.RowIndex >= 0)
            {
                object selectedItem = DataGridViewCustomer.SelectedRows;
                if (selectedItem.GetType() == typeof(Customer))
                {
                    CustomerForm CustForm = new CustomerForm(((Customer)selectedItem), this);
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
            else if (DataGridViewCustomer.CurrentCell.RowIndex >= 0)
            {
                btn_Edit.Enabled = true;
            }
            else
            {
                btn_Edit.Enabled = false;
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
