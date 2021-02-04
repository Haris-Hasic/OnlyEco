using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZdravaIshrana_UI
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
            LoginForm login = new LoginForm();
             login.ShowDialog();
              if(login.DialogResult==DialogResult.OK)
                     Application.Run(new StartMain());
            //Application.Run(new MainForm()); //Start stari
        }
    }
}
