/*
 * Name: Mohammed Juned Ahmed
 * Student ID: 300833356
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05_Lab09A
{
    class CourseManager{
        private static List<Course> courses = new List<Course>();


        public static void LoadCourses(string filename){
            TextReader reader = new StreamReader("course.txt");
            courses = new List<Course>();
            string title = reader.ReadLine();
            while (title != null)
            {
                string artist = reader.ReadLine();
                double length = Convert.ToDouble(reader.ReadLine());
                DisplayOption option = (DisplayOption)Enum.Parse(typeof(DisplayOption), reader.ReadLine());
                Course c = new Course(code, name, description, semester, prereqsites);
                option.Add(c);
                title = reader.ReadLine();
            }
            reader.Close();
        }


        public static void Display(DisplayOption option){
            for (int i = 0; i < courses.Count; i++){
                Console.WriteLine(courses[i]);
            }
        }
        public static void Display(DisplayOption option, string toMatch){

        }
    }
}
