using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_Liskov_substitution_principle
{
    class CustomerwithRead : IDatabase, IDatabaseV1
    {

        public virtual void Add(string s)
        {
            //Customer obj = new Customer();
            //obj.Add(s);
        }
        public virtual void Read()
        {
            // Implements  logic for read
        }
    }
}
