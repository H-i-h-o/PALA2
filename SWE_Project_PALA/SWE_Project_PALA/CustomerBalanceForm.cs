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
    public partial class CustomerBalanceForm : Form
    {
        private Customer Cust;
        private Form1 Form;
        public CustomerBalanceForm(Form1 form, Customer cust)
        {
            InitializeComponent();

            Form = form;
            Cust = cust;
            LableCustomerName.Text = cust.FirstName + " " + cust.LastName;
            labelCurrentBalance.Text = Convert.ToString(cust.AccountBalance);

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTakeIn_Click(object sender, EventArgs e)
        {
            Cust.ChangeToAccountBalance(Math.Abs(Convert.ToInt32(txtBoxAccountBalance.Text)));
            this.Close();

            Form.RefreshListBox(this,new EventArgs());     
        }

        private void btn_expense_Click(object sender, EventArgs e)
        {
            Cust.ChangeToAccountBalance(-1 * Math.Abs(Convert.ToInt32(txtBoxAccountBalance.Text)));
            this.Close();

            Form.RefreshListBox(this, new EventArgs());
            
        }
    }
}
