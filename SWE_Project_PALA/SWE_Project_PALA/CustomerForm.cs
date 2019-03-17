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
    public partial class CustomerForm : Form
    {
        public event EventHandler NewCustomerAvailable;
        private readonly Form1 _MainForm;

        public CustomerForm(Form1 mainForm)
        {
            _MainForm = mainForm;
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Email.CheckEmailInput(txtBoxEmail.Text))
            {
                Customer NewCustomer = new Customer(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxEmail.Text, _MainForm.GetNewCustomerNumber());
                NewCustomerAvailable?.Invoke(this, new EventArgsNewCustomer(NewCustomer));
                this.Close();
            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            txtBoxFirstName.BackColor = System.Drawing.Color.Green;
        }

        private void txtBoxLastName_TextChanged(object sender, EventArgs e)
        {
            txtBoxLastName.BackColor = System.Drawing.Color.Green;

        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            txtBoxEmail.BackColor = Email.CheckEmailInput(txtBoxEmail.Text) ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }
    }
}
