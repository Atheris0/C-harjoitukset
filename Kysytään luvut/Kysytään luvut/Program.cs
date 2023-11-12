using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kysytään_luvut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna 1. sivun pituus: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna 2. sivun pituus: ");
            int b = Convert.ToInt32(Console.ReadLine());

            double tulos;
            tulos = Math.Sqrt((a*a) + (b*b));

            Console.WriteLine($"Pitkän sivun pituus on {tulos}");
            Console.ReadLine();
        }
    }
}
