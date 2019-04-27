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
        }
        private void Form1_Load(object sender, EventArgs e)
        { 

            CustList = LoadCustomList();
            CustList.CustomerListChangedHappened += new EventHandler(RefreshListBox);
            CustList.WriteToLogFileAvailable += new EventHandler(HandleLogFiles);

            listViewCustomer.View = View.Details;
            listViewCustomer.GridLines = true;
            listViewCustomer.FullRowSelect = true;
            listViewCustomer.AllowColumnReorder = true;
            listViewCustomer.FullRowSelect = true;
            listViewCustomer.GridLines = true;
            listViewCustomer.MultiSelect = false;

            listViewCustomer.Columns.Add("Nr", 30);
            listViewCustomer.Columns.Add("First Name", 70);
            listViewCustomer.Columns.Add("Last Name", 70);
            listViewCustomer.Columns.Add("E-Mail Address", 120);
            listViewCustomer.Columns.Add("Open Balance [€]", 30);
            listViewCustomer.Columns.Add("Last Change", 50);
            listViewCustomer.Columns.Add("Post Code", 40);
            listViewCustomer.Columns.Add("City", 70);
            listViewCustomer.Columns.Add("Street", 50);
            listViewCustomer.Columns.Add("Nr.", 30);

            CustList.CustomerListChanged();

        }

        public static void HandleLogFiles(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(EventArgsLogFileEntryAvailable))
            {
                if (sender.GetType() == typeof(PasswordForm))
                {
                    CSVHandling.StringToCSV(((EventArgsLogFileEntryAvailable)e).StringToWrite, PathLoginLogFile);
                }
                else if (sender.GetType() == typeof(CustomerList))
                {
                    CSVHandling.StringToCSV(((EventArgsLogFileEntryAvailable)e).StringToWrite, PathCustomerDeleteLogFile);
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
            CustomerList myCustList = new CustomerList();
            listViewCustomer.Items.Clear();

            if (e.GetType() == typeof(EventArgsListBox))
            {
                myCustList.CustList = ((EventArgsListBox) e).CustList;
            }
            else
            {
                myCustList.CustList = CustList.CustList;
            }

            for (int i = 0; i < myCustList.CustList.Count; i++)

            {
                Customer Cust = myCustList.CustList[i];

                string[] arr = new string[11];
                ListViewItem itemToAdd;

                arr[0] = Cust.CustomerNumber.ToString();
                arr[1] = Cust.FirstName;
                arr[2] = Cust.LastName;
                arr[3] = Cust.EmailAddress.EmailAddress;
                arr[4] = Cust.AccountBalance.ToString();
                arr[5] = Cust.LastAccess.ToShortDateString();
                arr[6] = Cust.CustAdresse.PostCode.ToString();
                arr[7] = Cust.CustAdresse.City;
                arr[8] = Cust.CustAdresse.Street;
                arr[9] = Cust.CustAdresse.StreetNr;

                itemToAdd = new ListViewItem(arr);
                itemToAdd.Text = Cust.CustomerNumber.ToString();

                listViewCustomer.Items.Add(itemToAdd);

            }

            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;

            SaveCustomList();
        }

        private void listViewCustomer_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = CustList.CustList.Find(x => x.CustomerNumber.Equals(Convert.ToInt32(listViewCustomer.SelectedItems[0].SubItems[0].Text)));

            if (selectedItem.GetType() == typeof(Customer))
            {
                CustomerBalanceForm custBalanceForm = new CustomerBalanceForm(this, (Customer)selectedItem);
                custBalanceForm.Show();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (listViewCustomer.SelectedIndices[0] >= 0)
            {
                var selectedItem = CustList.CustList.Find(x => x.CustomerNumber.Equals(Convert.ToInt32(listViewCustomer.SelectedItems[0].SubItems[0].Text)));

                if (selectedItem.GetType() == typeof(Customer))
                {
                    CustomerForm CustForm = new CustomerForm(((Customer) selectedItem), this);
                    CustForm.NewCustomerAvailable += new EventHandler(CustList.AddCustomer);
                    CustForm.CustomerDeleteAvailable += new EventHandler(CustList.DeleteCustomer);

                    CustForm.Show();
                }
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

                        default:
                            break;
                    }
                }
                //what to do with sublist?? does it overwrite the whole customer list??
                if(SFForm.FilterList)
                {
                    switch (SFForm.FilterBy)
                    {
                        case "First name":
                            SubList.CustList = CustList.FilterByFirstName(SFForm.FilterSearchString);
                            break;

                        case "Last name":
                            SubList.CustList = CustList.FilterByLastName(SFForm.FilterSearchString);
                            break;

                        case "Email":
                            SubList.CustList = CustList.FilterByEmail(SFForm.FilterSearchString);
                            break;

                        case "Postal code":
                            SubList.CustList = CustList.FilterByPostCode(SFForm.FilterSearchString);
                            break;

                        case "City":
                            SubList.CustList = CustList.FilterByCity(SFForm.FilterSearchString);
                            break;

                        default:
                            break;
                    }
                }

                RefreshListBox(this, new EventArgsListBox(SubList.CustList));
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (listViewCustomer.SelectedIndices[0] >= 0)
            {
                var selectedItem = CustList.CustList.Find(x => x.CustomerNumber.Equals(Convert.ToInt32(listViewCustomer.SelectedItems[0].SubItems[0].Text)));

                if (selectedItem.GetType() == typeof(Customer))
                {
                    CustList.DeleteCustomer(this, new EventArgsCustomerChange((Customer)selectedItem));
                }
            }
        }

        private void listViewCustomer_Click(object sender, EventArgs e)
        {
            if (listViewCustomer.SelectedIndices.Count > 0)
            {
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;

                tableLayoutPanelDetails.Visible = true;

                var selectedItem = CustList.CustList.Find(x => x.CustomerNumber.Equals(Convert.ToInt32(listViewCustomer.SelectedItems[0].SubItems[0].Text)));

                if (selectedItem.GetType() == typeof(Customer))
                {
                    fillCustomerDetails(selectedItem);
                }
            }
            else
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;

                tableLayoutPanelDetails.Visible = false;
            }
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            RefreshListBox(this, new EventArgsListBox(this.CustList.CustList));
        }

        private void fillCustomerDetails(Customer Cust)
        {
            lab_CustNr.Text = Cust.CustomerNumber.ToString();
            lab_name.Text = Cust.FirstName + " " + Cust.LastName;
            lab_balance.Text = Cust.AccountBalance.ToString();
            lab_email.Text = Cust.EmailAddress.EmailAddress;
            lab_Adress.Text = Cust.CustAdresse.ToString();
        }
    }
}
