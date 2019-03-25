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
    public partial class PasswordForm : Form
    {
        public bool PasswordWasOK { get; private set; }
        private const string Password = "password";

        public PasswordForm()
        {
            InitializeComponent();
            PasswordWasOK = false;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if(PasswordBox.Text == Password)
            {
                PasswordWasOK = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                PasswordBox.Text = string.Empty;
                MessageBox.Show("The entered password was wrong."+ Environment.NewLine+"Please try it again!");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            PasswordWasOK = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
