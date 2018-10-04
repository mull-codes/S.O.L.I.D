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
    }
}
