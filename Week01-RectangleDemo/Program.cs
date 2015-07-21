using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01_RectangleDemo
{
    class Program
    {
        #region MAIN
        static void Main(string[] args)
        {
            /*
            Rectangle bigRect = new Rectangle();
            bigRect.length = 20;
            bigRect.width = 30;
            */
            Rectangle smallRectangle = CreateRectangle(4, 5);
            DescribeRectangle(smallRectangle);
            CalculateAndDisplayArea(smallRectangle);

        }
        #endregion
        #region DescribeRectangle
        static void DescribeRectangle(Rectangle rectangle)
        {
            Console.WriteLine("Length: {0}\nWidth: {1}", rectangle.length, rectangle.width);
        }
        #endregion
        #region CalculateAndDisplayArea
        static void CalculateAndDisplayArea(Rectangle rect)
        {
            int area = rect.length * rect.width;
            Console.WriteLine("Area: {0}", area);
        }
        #endregion
        #region CreateRectangle
        static Rectangle CreateRectangle(int len, int wid)
        {
            Rectangle rectangleDim = new Rectangle();
            rectangleDim.length = len;
            rectangleDim.width = wid;
            return rectangleDim;
        }
        #endregion
    }
}
