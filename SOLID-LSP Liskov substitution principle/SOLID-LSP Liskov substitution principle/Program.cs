using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_Liskov_substitution_principle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new SilverCustomer());
            Customers.Add(new goldCustomer());
            //Customers.Add(new Enquiry());

            //Write to file
            foreach (Customer o in Customers)
            {
                o.Add("Name");
            }

            Console.WriteLine(Customers.Count());

            Console.ReadLine();
        }
    }
}
