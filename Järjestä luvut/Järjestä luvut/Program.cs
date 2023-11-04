using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Järjestä_luvut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());

            if (luku1 < luku2) { 
                Console.Write(luku1 + " ");
                Console.Write(luku2);
            } else if (luku1 > luku2)
            {
                Console.Write(luku2 + " ");
                Console.Write(luku1);
            } else if (luku1 == luku2)
            {
                Console.Write("Luvut samat");
            }

            Console.ReadLine();
        }
    }
}
