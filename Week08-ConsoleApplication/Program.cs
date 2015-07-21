using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int i = 1;
            int j = 2;
            int k = 5;
            a[1] = 5;
            a[2] = 5;
            try
            {
                //   int result1 = a[i] / a[j];
                //int result2 = a[i] / a[k];
                Console.Write("Enter a string");
                string s = Console.ReadLine();
                StringHandler mystring = new StringHandler();
                mystring.MyString = s;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
