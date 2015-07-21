using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08_ConsoleApplication
{
    class ThirteenException : Exception
    {
        public ThirteenException()
            : base()
        {

        }

        public ThirteenException(String msg)
        {
            Console.WriteLine(msg);
        }
    }
}
