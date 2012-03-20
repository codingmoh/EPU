<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
            MSDB db = MSDB.GetInstance();
            db.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow mainWindow = new MainWindow();
            Application.Run(mainWindow);
        }
    }
}
>>>>>>> 72ad3d3fb2215936162b4e38bfad5b5c56b657df
