﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Project_PALA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                PasswordForm PWForm = new PasswordForm();
                PWForm.WriteToLogFileAvailable += new EventHandler(Form1.HandleLogFiles);

                //access only with allowed password
                if ((PWForm.ShowDialog() == DialogResult.OK) && PWForm.PasswordWasOK)
                {
                    Application.Run(new Form1());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An unhandled exception occured. " + Environment.NewLine + ex.Message);
            }
        }
    }
}
