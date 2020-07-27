
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development_Capstone
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string LoggedinUser;

        [STAThread]
        static void Main()
        {
            //Set the DataDirectory variable to be the users application data folder.
            //This is used in the app.config file to find the database location
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

            //Run Main.cs which will take over and handle all further application processing.
            //The main.cs form is also the MDI container which will hold all other forms.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

        }
    }
}
