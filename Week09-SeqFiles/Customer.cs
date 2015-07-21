using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09_SeqFiles
{
    class Customer
    {
        private int custId;
        private string custName;
        private double custSales;

        public Customer() { }

        public Customer(int custId, string custName, double custSales)
        {
            this.custId = custId;
            this.custName = custName;
            this.custSales = custSales;
        }

        public string ToString()
        {
            return custId + ", " + custName + ", " + custSales;
        }



    }
}
