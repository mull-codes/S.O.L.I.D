using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_Liskov_substitution_principle
{
    interface IDiscount
    {
        double getDiscount(double TotalSales);
    }


    interface IDatabase
    {
        void Add(string s);
        //void Read(); // Added for new clients.
        //Now by changing the current interface you are doing an awful thing, disturbing the 1000 satisfied current client’s , even when they are not interested in the “Read” method.You are forcing them to use the “Read” method.
    }

    interface IDatabaseV1 : IDatabase // Gets the Add method
    {
        void Read();
    }

    interface ILogger
    {
        void Handle(string error);
    }
}
