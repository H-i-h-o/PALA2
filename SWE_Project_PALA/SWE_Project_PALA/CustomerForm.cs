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
        public event EventHandler CustomerDeleteAvailable;
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

            txtBoxPostCode.Text = cust.CustAdresse.PostCode.ToString();
            txtBoxCity.Text = cust.CustAdresse.City;
            txtBoxStreet.Text = cust.CustAdresse.Street;
            txtBoxStreetNr.Text = cust.CustAdresse.StreetNr.ToString();
            
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
                    Cust.ChangeAdresse(new Address(txtBoxStreet.Text, (txtBoxEmail.Text), int.Parse(txtBoxPostCode.Text), txtBoxCity.Text));
                    this.Close();
                }
            }
            else
            {
                if (Email.CheckEmailInput(txtBoxEmail.Text))
                {
                    Cust = new Customer(_MainForm.GetNewCustomerNumber(),txtBoxFirstName.Text, txtBoxLastName.Text, new Email(txtBoxEmail.Text), new Address(txtBoxStreet.Text, (txtBoxStreetNr.Text), int.Parse(txtBoxPostCode.Text), txtBoxCity.Text));
                    NewCustomerAvailable?.Invoke(this, new EventArgsCustomerChange(Cust));
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

        private void txtBox_TextChangedString(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                ((TextBox)sender).BackColor = System.Drawing.Color.Green;
            }
        }

        private void txtBox_TextChangedInt(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                int nr;
                if (int.TryParse(((TextBox)sender).Text, out nr))
                {
                    ((TextBox)sender).BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    ((TextBox)sender).BackColor = System.Drawing.Color.Red;

                }
            }
            if (txtBoxPostCode.Text.Length > 0 &&
                txtBoxCity.Text.Length > 0 &&
                Email.CheckEmailInput(txtBoxEmail.Text) &&
                txtBoxFirstName.Text.Length > 0 &&
                txtBoxLastName.Text.Length > 0 &&
                txtBoxStreet.Text.Length > 0 &&
                txtBoxStreetNr.Text.Length > 0)
            {
                btn_Delete.Enabled = true;
                btn_Cancle.Enabled = true;
            }
            else
            {
                btn_Delete.Enabled = false;
                btn_Cancle.Enabled = false;
            }
        }


        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            txtBoxEmail.BackColor = Email.CheckEmailInput(txtBoxEmail.Text) ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            CustomerDeleteAvailable?.Invoke(this, new EventArgsCustomerChange(Cust));

        }
    }
}
