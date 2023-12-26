using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mitä haluat tehdä?\r\n1 - Laske yhteen\r\n2 - Vähennä\r\n3 - Kerro\r\n4 - Jaa");
            Console.WriteLine();
            Console.Write("Anna valintasi");
            int valinta = Convert.ToInt32(Console.ReadLine());

            if (valinta >= 1 && valinta <=4) {
                Console.WriteLine(valinta);
            } else { Console.WriteLine("Valinnan piti olla 1 - 4"); }


            Console.ReadLine();
        }
    }
}
