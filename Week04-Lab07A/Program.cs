using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04_Lab07A
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Astronaut> astronaut = new List<Astronaut>(){
                Astronaut.CreateAstronaut("Yuri", "Russian"),
                Astronaut.CreateAstronaut("Ahdieh", "Canadian"),
                Astronaut.CreateAstronaut("Matt", "Canadian"),
                Astronaut.CreateAstronaut("Omid", "French"),
                Astronaut.CreateAstronaut("Max", "US"),
                Astronaut.CreateAstronaut("Tyler", "British"),
                Astronaut.CreateAstronaut("Buzz", "Toy Story"),
            };

        }
    }
}
