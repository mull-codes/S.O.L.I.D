using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOLID_LSP_Liskov_substitution_principle
{
    class Customer : IDiscount, IDatabase
    {
        
        private FileLogger logger = new FileLogger();
        public virtual void Add(string s)
        {
            try
            {
                //StreamWriter sw = new StreamWriter("customerDB/Customers.dat", append: true);
                //sw.WriteLine(s);
                string insert = s + Environment.NewLine;
                File.AppendAllText("customerDB/Customers.dat", insert);
            }
            catch (Exception err)
            {

                logger.Handle(err.ToString());
            }
        }

        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }

    class SilverCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }
    }

    class goldCustomer : SilverCustomer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }

    //class Enquiry : Customer
    //{
    //    public override double getDiscount(double TotalSales)
    //    {
    //        return base.getDiscount(TotalSales) - 5;
    //    }

    //    public override void Add(string s)
    //    {
    //        throw new Exception("Not allowed");
    //    }
    //}

    class Enquiry : IDiscount
    {
        public double getDiscount(double TotalSales)
        {
            return TotalSales - 5;
        }
    }
}
