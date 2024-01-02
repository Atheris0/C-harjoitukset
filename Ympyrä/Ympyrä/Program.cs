using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ympyrä
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ympyra ympyra1 = new Ympyra(7, 14, 5);
            Ympyra ympyra2 = new Ympyra(10, 6, 5);

            double distance = Math.Sqrt((ympyra1.x - ympyra2.x) * (ympyra1.x - ympyra2.x) + (ympyra1.y - ympyra2.y) * (ympyra1.y - ympyra2.y));
            //Console.WriteLine(distance);
            if (ympyra1.r > distance + ympyra2.r)
            {
                Console.WriteLine("Ympyra2 on Ympyra1:n sisällä");
            }
            else if(ympyra2.r > distance + ympyra1.r)
            {
                Console.WriteLine("Ympyra1 on Ympyra2:n sisällä");
            }
            else if (ympyra1.r +  ympyra2.r <= distance)
            {
                Console.WriteLine("Ympyrät ovat erillään");
            }
            else
            {
                Console.WriteLine("Ympyrät ovat osittain toistensa päällä");
            }
            Console.ReadLine();
        }
    }
}
