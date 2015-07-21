/*
 * Name: Mohammed Juned Ahmed
 * Student ID: 300833356
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05_Lab09A
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseManager.LoadCourses("course.txt");

            Console.WriteLine("\nAll courses");
            CourseManager.Display(DisplayOption.All);

            string toSearch = "COMP100";
            Console.WriteLine("\nWith prerequsite " + toSearch);
            CourseManager.Display(DisplayOption.Prerequsite, toSearch);


            Console.WriteLine("\nWith title " + toSearch);
            CourseManager.Display(DisplayOption.Code, toSearch);

            toSearch = "Programing I";
            Console.WriteLine("\nWith name " + toSearch);
            CourseManager.Display(DisplayOption.Name, toSearch);

            toSearch = "2";
            Console.WriteLine("\nIn semester " + toSearch);
            CourseManager.Display(DisplayOption.Semester, toSearch);
        }
    }
}
