using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOLID_SRP_Single_responsibility_principle
{
    class CustomerLogger
    {
        private FileLogger logger = new FileLogger();
        public virtual void Add(string s)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("customerDB/CustomersLogger.dat", append: true))
                {
                    sw.WriteLine(s);

                }
            }
            catch (Exception err)
            {

                logger.Handle(err.ToString());
            }
        }
    }
}
