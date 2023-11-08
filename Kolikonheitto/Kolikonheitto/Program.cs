using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolikonheitto
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //testi array
            int[] testi = { 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 1 };
            Kolikko kolikko = new Kolikko(testi);

            //lasketaan kruunut ja klaavat
            kolikko.SuperCounter();
            //tulostetaan tulokset
            Console.WriteLine(kolikko.Stats());

            Console.ReadLine();
        }
    }
}
