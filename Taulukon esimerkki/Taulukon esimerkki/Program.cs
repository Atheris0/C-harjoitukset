using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukon_esimerkki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taulukko luvut = new Taulukko(5);

            luvut.Lisaa(5);
            luvut.Tulosta();
            luvut.Lisaa(3);
            luvut.Tulosta();
            luvut.Lisaa(8);
            luvut.Tulosta();
            Console.WriteLine("Taulukon suurin on {0}", luvut.HaeSuurin());
            Console.WriteLine("Lukujen keskiarvo on {0:0.0}", luvut.LaskeKeskiarvo());
            Console.ReadLine();
        }
    }
}
