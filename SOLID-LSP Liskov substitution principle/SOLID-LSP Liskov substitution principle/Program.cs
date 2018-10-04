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
            //List<Customer> Customers = new List<Customer>();
            //Customers.Add(new SilverCustomer());
            //Customers.Add(new goldCustomer());
            //Customers.Add(new Enquiry());

            //IDatabase interfaces = new Customer(new EverViewerLogger());
            List<IDatabase> Customers = new List<IDatabase>();
            Customers.Add(new SilverCustomer(new EmailLogger()));
            Customers.Add(new GoldCustomer(new EmailLogger()));

            //Write to file
            foreach (Customer o in Customers)
            {
                o.Add(o.getCustomerType());
                //o.Read();
            }

            Console.WriteLine(Customers.Count());

            Console.ReadLine();
        }
    }
}
