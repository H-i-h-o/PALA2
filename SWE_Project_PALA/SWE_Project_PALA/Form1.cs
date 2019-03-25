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
        private readonly string Path = Application.StartupPath + "\\CList_crypted.csv";
        

        public Form1()
        {
            //CustList = LoadCustomList();
            //CustList.CustomerListChangedHappened += new EventHandler(RefreshListBox);
            InitializeComponent();
            CustList = LoadCustomList();
            RefreshListBox(null, null);

            //Show Passwordform
            //PasswordForm PWForm = new PasswordForm();
            //if ((PWForm.ShowDialog() != DialogResult.OK) || !PWForm.PasswordWasOK)
            //{
            //    this.Close();
            //}

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
            listBox1.Items.Clear();
            foreach (Customer Cust in CustList.CustList)
            {
                listBox1.Items.Add(Cust);
            }
            btnEdit.Enabled = false;
            SaveCustomList();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                object selectedItem = listBox1.SelectedItem;
                if (selectedItem.GetType() == typeof(Customer))
                {
                    CustomerForm CustForm = new CustomerForm(((Customer) selectedItem), this);
                    CustForm.Show();
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                btnEdit.Enabled = true;
            }
        }

        private void SaveCustomList()
        {
            CSVHandling.SaveCustomerListToCSV(CustList,Path);
        }

        private CustomerList LoadCustomList()
        {
            if (File.Exists(Path))
            {
                return CSVHandling.LoadCustomerListFromCSV(Path);
            }
            else
            {
                return new CustomerList();
            }
        }
    }
}
