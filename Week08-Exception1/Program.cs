using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08_Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2, var3;
            Console.WriteLine("\nEnter the first number");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the second number");
            var2 = Convert.ToInt32(Console.ReadLine());
            //
            // do the division
            //
            try
            {
                var3 = var1 / var2;
                Console.WriteLine("\nThe result is " + var3);
            }
            catch (ArithmeticException e)
            {
                //Console.WriteLine("Math police detected division by zero");
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("This block always runs");
            }
        }
    }
}
