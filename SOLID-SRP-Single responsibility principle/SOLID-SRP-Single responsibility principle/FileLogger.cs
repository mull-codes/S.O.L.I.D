using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOLID_SRP_Single_responsibility_principle
{
    class FileLogger
    {
        public void Handle(string error) {
            File.WriteAllText(@"logs/cust_add_error_logs.txt", error);
        }
    }
}
