using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhteenlasku_funktio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Potenssi(7));
            Console.ReadLine();

        }
        static int Potenssi(int luku)
        {
            int result = luku * luku;
            return result;
        }
    }
}
