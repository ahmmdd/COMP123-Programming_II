using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01_RectangleComplete
{
    public class Rectangle
    {
        //fields - store values
        private int length;
        private int width;

        //constructor, same name as class
        //no return type
        public Rectangle(int wid, int len)
        {
            length = len;
            width = wid;
        }

        //this method is called when an object
        //needs to be printed
        public override string ToString()
        {
            return "width: " + width + ", length:" + length;
        }

        //method to calculate area
        public int GetArea()
        {
            return width * length;
        }
    }
}
