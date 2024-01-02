using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhteenlasku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mihin asti lasketaan yhteen?");
            int luku = Convert.ToInt32(Console.ReadLine());
            int summa = 0;

            for (int i = 1; i <= luku; i++)
            {
                summa += i;
            }

            Console.WriteLine($"Summa on {summa}");
            Console.ReadLine();
        }
    }
}
