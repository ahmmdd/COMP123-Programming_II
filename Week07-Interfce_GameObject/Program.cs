using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07_Interface_GameObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Vampire v = new Vampire();
            Console.WriteLine(v.Position);
            Console.WriteLine(((IAttackable)v).Attack());
            Console.WriteLine(((IProtectable)v).Attack());

        }
    }
}
