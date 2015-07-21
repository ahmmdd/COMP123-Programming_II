using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Week10_Test02_Demo
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AcctReceivable acctsReceivable;
            Invoice invoice;
            Employee employee;
            string filename = "invoice.txt";
            FileStream invoiceFile;
            StreamWriter writer;

            string custName = txtCustomerName.Text;
            double amount = Convert.ToDouble(txtAmount.Text);
            invoice = new Invoice(amount, custName);
            employee = new Employee("John Smith", 1000, 10, 15.50);
            acctsReceivable = (Invoice)invoice;
            acctsReceivable = (Employee)employee;

           // txtTotal.Text = acctsReceivable.amountDue().ToString();
            txtTotal.Text = acctsReceivable.amountDue().ToString();

            //try
            //{
                if (File.Exists(filename))
                {
                    invoiceFile = new FileStream(filename, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    invoiceFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
                }
                writer = new StreamWriter(invoiceFile);
                writer.WriteLine(invoice.ToString());
                writer.Close();
                invoiceFile.Close();

            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
           // }



        }
    }
}
