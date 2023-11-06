using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Henkilöauto auto1 = new Henkilöauto("Toyota", "Corolla", 2022, 77.5, 4, 3.5);
            Console.WriteLine(auto1.Merkki);

            Pakettiauto auto2 = new Pakettiauto("Ford", "Transit", 2022, 700.00, 10, "Umpipaku");
            Console.WriteLine(auto2.Tyyppi);

            KuormaAuto auto3 = new KuormaAuto("Volvo", "FH16", 2022, 150, 25000, 80.0);
            Console.WriteLine(auto3.KuormaTilaKoko);

            Console.ReadLine();
        }
    }
}
