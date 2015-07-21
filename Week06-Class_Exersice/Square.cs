using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06_Class_Excersice
{
    class Square
    {
        protected int Length { get; set; }
        public int Area { get { return Length * Length; } }
        public Square(int length) { Length = length; }
    }
    class Cube : Square
    {
        public Cube(int length) : base(length) { }
        public new int Area { get { return Length * Length * 6; } }
    }
}
