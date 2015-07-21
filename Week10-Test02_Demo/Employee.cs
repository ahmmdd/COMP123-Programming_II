using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_Test02_Demo
{
    class Employee : AcctReceivable
    {
        private string employeeName;
        private double salary;
        private int workhours;
        private double hourlyrate;
        private const double EI = 0.05;
        private const double FED = 0.15;


        public Employee(string employeeName, double salary, int workhours, double hourlyrate)
        {
            this.employeeName = employeeName;
            this.salary = salary;
            this.workhours = workhours;
            this.hourlyrate = hourlyrate;
        }

        double AcctReceivable.amountDue()
        {
            double grossSalary = workhours * hourlyrate;
            double EIamount = grossSalary * EI;
            double FEDamount = grossSalary * FED;
            return grossSalary - EIamount - FEDamount;
        }
    }
}
