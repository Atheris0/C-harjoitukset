using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitä_tapahtuu
{
    internal class iPlusPlus
    {
        static void Main(string[] args)
        {
            int luku = 3;
            Console.WriteLine(luku++ == 3);
            Console.WriteLine(++luku == 4);
            Console.ReadKey();
        }
    }
}
