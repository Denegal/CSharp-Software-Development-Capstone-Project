using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Logic
{

    // The Logging class is a static class with functions used to read/write log messages and debugging information to file
    public static class Logging
    {

        // This method is simply used to write a message to a log file
        // It handles timestamping as well.
        public static void AddToLog(string logfile, string message)
        {
            using (StreamWriter file = new StreamWriter(logfile, true))
            {
                file.WriteLine(DateTime.UtcNow.ToString() + " > " + message);
            }
        }
    }
}
