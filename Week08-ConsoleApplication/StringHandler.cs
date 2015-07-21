using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08_ConsoleApplication
{
    class StringHandler
    {
        protected string myString;
        public string MyString
        {
            get
            {
                return myString;
            }
            set
            {
                if (value.Length == 13)
                {
                    myString = "";
                    throw (new ThirteenException("Yikes"));
                }
                else myString = value;
            }
        }
    }
}
