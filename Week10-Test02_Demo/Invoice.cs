using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_Test02_Demo
{
    class Invoice : AcctReceivable
    {
        private string custName;
        private double amount;
        private const double TAX = 1.15;

        public Invoice(double amount, string custName)
        {
            this.amount = amount;
            this.custName = custName;
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string CustName {
            get { return custName; }
            set { custName = value; }
        }

        double AcctReceivable.amountDue()
        {
            return amount * TAX;

        }

        public override string ToString()
        {
            AcctReceivable invoice;
            invoice = (Invoice)this;
            return custName + ", " + invoice.amountDue();
        }

    }
}
