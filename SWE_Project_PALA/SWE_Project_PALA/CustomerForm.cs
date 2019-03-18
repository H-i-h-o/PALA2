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
        private Customer Cust;
        private bool importedPerson;

        public CustomerForm(Form1 mainForm)
        {
            _MainForm = mainForm;
            InitializeComponent();
            importedPerson = false;
        }

        public CustomerForm(Customer cust, Form1 mainForm)
        {
            InitializeComponent();

            _MainForm = mainForm;
            Cust = cust;
            txtBoxEmail.Text = cust.EmailAddress.Print();
            txtBoxFirstName.Text = cust.FirstName;
            txtBoxLastName.Text = cust.LastName;

            importedPerson = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (importedPerson)
            {
                if (Email.CheckEmailInput(txtBoxEmail.Text))
                {
                    Cust.ChangeEmail(txtBoxEmail.Text);
                    Cust.ChangeName(txtBoxFirstName.Text,txtBoxLastName.Text);
                    this.Close();
                }
            }
            else
            {
                if (Email.CheckEmailInput(txtBoxEmail.Text))
                {
                    Cust = new Customer(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxEmail.Text,
                        _MainForm.GetNewCustomerNumber());
                    NewCustomerAvailable?.Invoke(this, new EventArgsNewCustomer(Cust));
                    this.Close();
                }
            }
            _MainForm.RefreshListBox(this, new EventArgs());
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
