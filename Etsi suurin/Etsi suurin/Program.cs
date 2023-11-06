using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etsi_suurin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[3];

            for (int i = 0; i < luvut.Length; i++)
            {
                Console.Write("Anna luku: ");
                luvut[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(luvut.Max());

            Console.ReadLine();
        }
    }
}
