using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOLID_SRP_Single_responsibility_principle
{
    class Customer
    {
        public void Add(string s)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("customerDB/Customers.dat", append: true))
                {
                    sw.WriteLine(s);
                    
                }
            }
            catch (Exception err)
            {

                File.WriteAllText(@"logs/cust_log.txt", err.ToString());
            }
        }
    }
}



/*The above customer class is doing things WHICH HE IS NOT SUPPOSED TO DO.
Customer class should do customer datavalidations, call the customer data access layer etc,
but if you see the catch block closely it also doing LOGGING activity.
In simple words its over loaded with lot of responsibility.

So tomorrow if add a new logger like event viewer I need to go and change the “Customer”class,
that’s very ODD.*/
