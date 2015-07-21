using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01_DateDemo
{
    public class Date
    {
        private int year;
        private int month;
        private int day;

        public Date(int y, int m, int d)
        {
            day = d;
            month = m;
            year = y;
        }
        public override string ToString()
        {
            return string.Format("{1:d2}/{2:d2}/{0}",
                year, month, day);
        }
    }
}
