using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09_Serializing
{
    [Serializable]
    class Customer
    {
        private int custId;
        private string custName;

        
        public Customer(int custId, string custName)
        {
            this.custId = custId;
            this.custName = custName;
        }

        public string ToString()
       {
           return custId + ", " + custName;
        }

    }
}
