using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xmldwnld
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
            //Application.Run(new xmldwnld());
           // SplashScreen.ShowSplashScreen();
            xmldwnld mainForm = new xmldwnld(); //this takes ages
           // System.Threading.Thread.Sleep(3000);
          //  SplashScreen.CloseForm();
            Application.Run(mainForm);
        }
    }
}
