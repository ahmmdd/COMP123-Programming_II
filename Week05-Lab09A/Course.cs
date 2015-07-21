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
    public class Course{
        public string Code { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
        public string Prerequsite { get; private set; }
        public int Semester { get; private set; }

        public override string ToString(){
            return string.Format("{0}/{1}/{2}/{3}/{4}", Code, Name, Description, Semester,Prerequsite);
        }

        public Course(string code, string name, string description, string semester, string prereqsites){
            Code = code;
            Name = name;
            Description = description;
            Semester = Convert.ToInt32(semester);
            Prerequsite = prereqsites;
        }
    }
}
