/*
 * Name: Mohammed Juned Ahmed
 * Student ID: 300833356
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02_Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational rational1 = new Rational(1, 2);
            Rational rational2 = new Rational(2, 3);
            Rational rational3 = new Rational(1, 3);
            Rational rational4 = new Rational(2, 5);

            Console.WriteLine("Rational 1: {0}\nRational 2: {1}\nRational 3: {2}\nRational 4: {3}", rational1, rational2, rational3, rational4);


            Console.Write("\nRational2 + Rational1: {0} {1} {2}", rational2, "+", rational1);
            rational2.IncreaseBy(rational1);
            Console.Write(" = {0}", rational2);

            Console.Write("\nRational4 - Rational3: {0} {1} {2}", rational4, "-", rational3);
            rational4.DecreaseBy(rational3);
            Console.Write(" = {0}", rational4);

            Console.Write("\nRational1 + Rational3: {0} {1} {2}", rational1, "+", rational3);
            rational1.IncreaseBy(rational3);
            Console.Write(" = {0}", rational1);

            Console.ReadLine();
        }
    }
}
