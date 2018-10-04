using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOLID_LSP_Liskov_substitution_principle
{
    class FileLogger : ILogger
    {
        public void Handle(string error)
        {
            //StreamWriter sw = new StreamWriter("logs/cust_add_error_logs.txt", append: true);
            //sw.WriteLine(error);
            string err = "Error: " + error + Environment.NewLine + Environment.NewLine;
            File.AppendAllText("logs/cust_add_error_logs.txt", err);
        }
    }

    class EverViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // log errors to event viewer
        }
    }

    class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // send errors in email
        }
    }
}
