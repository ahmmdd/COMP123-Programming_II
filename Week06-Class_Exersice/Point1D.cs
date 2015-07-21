using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06_Class_Excersice
{
    class Point1D
    {
        protected int x;
        public virtual Double Length { get { return Math.Abs(x); } }
        public Point1D(int x) { this.x = x; }
    }
    class Point2D : Point1D
    {
        protected int y;
        public override double Length { get { return Math.Sqrt(x * x + y * y); } }
        public Point2D(int x, int y) : base(x) { this.y = y; }

    }
    class Point3D : Point2D
    {
        protected int z;
        public override double Length { get { return Math.Sqrt(x * x + y * y + z * z); } }
        public Point3D(int x, int y, int z) : base(x, y) { this.z = z; }

    }

}
