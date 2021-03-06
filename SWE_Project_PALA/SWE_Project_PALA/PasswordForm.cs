﻿using System;
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
    /// <summary>
    /// form to get the password from the user in the beginning
    /// 
    /// </summary>
    public partial class PasswordForm : Form
    {
        public event EventHandler WriteToLogFileAvailable;

        public bool PasswordWasOK { get; private set; }
        private const string Password = "a";
        private int tryCoutner = 0;

        public PasswordForm()
        {
            InitializeComponent();
            PasswordWasOK = false;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            tryCoutner++;
            // only three wrong entries allowed, then a log file is written
            if (PasswordBox.Text == Password)
            {
                PasswordWasOK = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (tryCoutner == 3)
            {
                MessageBox.Show("The entered password was wrong the third time." + Environment.NewLine + "You reached the maximum number of inputs.");
                WriteToLogFileAvailable(this,new EventArgsLogFileEntryAvailable("Wrong Login; " + System.DateTime.Today.ToShortDateString()));

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
