using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Backoffice.DB;
using Backoffice.Entity;

namespace Backoffice
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
            MainWindow mainWindow = new MainWindow();
            Application.Run(mainWindow);
        }
    }
}
