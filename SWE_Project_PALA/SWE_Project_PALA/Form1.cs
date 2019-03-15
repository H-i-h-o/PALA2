using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Project_PALA
{
    public partial class Form1 : Form
    {
        public CustomerList CustList = new CustomerList();

        public Form1()
        {

            InitializeComponent();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            CustomerForm CustForm = new CustomerForm();
            CustForm.NewCustomerAvailable += new EventHandler(CustList.AddCustomer);

            CustForm.Show();
        }
    }
}
