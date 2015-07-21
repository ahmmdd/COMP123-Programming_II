using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01_RectangleComplete
{
    class Program
    {
        static void Main(string[] args)
        {

            //create rectangle object
            Rectangle rec = new Rectangle(4, 5);
            //print object
            Console.WriteLine(rec);
            Console.WriteLine(rec.GetArea());

            Console.WriteLine(new Rectangle(2, 3));
        }
    }
}
