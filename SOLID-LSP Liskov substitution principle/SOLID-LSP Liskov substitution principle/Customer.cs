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
        private string customerType;
        private ILogger obj;

        public Customer(ILogger i)
        {
            obj = i;
            customerType = "";
        }

        public void setCustomerType(string s)
        {
            this.customerType = s;
        }

        public virtual string getCustomerType()
        {
            return this.customerType;
        }

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
                if (customerType == "1")
                {
                    obj.Handle(err.Message.ToString() + " ::whatever error::");
                }
                else
                {
                    obj.Handle(err.Message.ToString() + " ::whatever else::");
                }

                //logger.Handle(err.ToString());
            }
        }

        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }

        public virtual void Read()
        {
            // Implements  logic for read
        }
    }

    class SilverCustomer : Customer
    {
        public SilverCustomer(ILogger i) : base(i)
        {
            this.setCustomerType("Silver");
        }

        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }

        public override string getCustomerType()
        {
            return base.getCustomerType();
        }
    }

    class GoldCustomer : SilverCustomer
    {
        public GoldCustomer(ILogger i) : base(i)
        {
            this.setCustomerType("Gold");
        }

        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }

        public override string getCustomerType()
        {
            return base.getCustomerType();
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
