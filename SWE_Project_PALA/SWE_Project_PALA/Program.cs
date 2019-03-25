using System;
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
               
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PasswordForm PWForm = new PasswordForm();
            if ((PWForm.ShowDialog() != DialogResult.OK) || !PWForm.PasswordWasOK)
            {
                
            }
            else
            {
                Application.Run(new Form1());
            }
            
        }
    }
}
