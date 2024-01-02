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
            
            Console.WriteLine(Yhteenlasku(1, 6));
            Console.ReadLine();

        }
        static int Yhteenlasku(int luku1, int luku2)
        {
            int result = luku1 + luku2;
            return result;
        }
    }
}
