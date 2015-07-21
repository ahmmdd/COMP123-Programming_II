using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06_Class_Excersice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Point1D

            Point1D p1 = new Point1D(3);
            Console.WriteLine("Length: {0:f2}", p1.Length);

            Point2D p2 = new Point2D(3, 4);
            Console.WriteLine("Length: {0:f2}", p2.Length);

            Point1D p6 = new Point2D(3, 4);
            Console.WriteLine("Length: {0:f2}", p6.Length);

            Point3D p3 = new Point3D(5, 6, 7);
            Console.WriteLine("Length: {0:f2}", p3.Length);


            Point1D p4 = new Point3D(5, 6, 7);
            Console.WriteLine("Length: {0:f2}", p4.Length);


            Point2D p5 = new Point3D(5, 6, 7);
            Console.WriteLine("Length: {0:f2}", p5.Length);

            #endregion
            #region Square
            /*
            Square s1 = new Square(2);
            Console.WriteLine("Area: " + s1.Area);

            Square s2 = new Square(10);
            Console.WriteLine("Area: " + s2.Area);


            Cube c1 = new Cube(2);
            Console.WriteLine("Area: " + c1.Area);


            Cube c2 = new Cube(3);
            Console.WriteLine("Area: " + c2.Area);

            Console.WriteLine("Area: {0}" , ((Square)c2).Area);
             */
            #endregion
        }
    }
}
