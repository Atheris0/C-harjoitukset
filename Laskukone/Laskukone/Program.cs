using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskukone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku1;
            int luku2;
            char operaattori;
            //ensimmäinen luvun tarkistus
            while (true)
            {
                Console.Write("Anna ensimmäinen luku: ");
                if (int.TryParse(Console.ReadLine(), out luku1))
                    break;
                else
                    Console.WriteLine("Virheellinen syöte. Syötä kelvollinen luku.");
            }
            //toinen luvun tarkistus
            while (true)
            {
                Console.Write("Anna toinen luku: ");
                if (int.TryParse(Console.ReadLine(), out luku2))
                    break;
                else
                    Console.WriteLine("Virheellinen syöte. Syötä kelvollinen luku.");
            }
            //operaattorin tarkistus
            while (true)
            {
                Console.Write("Valitse operaattori(+, -, /, *): ");
                if (char.TryParse(Console.ReadLine(), out operaattori))
                    break;
                else
                    Console.WriteLine("Virheellinen syöte. Syötä kelvollinen operaattori.");
            }

            double tulos = Laskutoimitus(luku1, luku2, operaattori);
            Console.WriteLine($"Tulos on: {tulos}");

            Console.ReadLine();

        }

        static double Laskutoimitus(int luku1, int luku2, char operaattori)
        {
            switch (operaattori)
            {
                case '+':
                    return luku1+luku2;
                case '-':
                    return luku1 - luku2;
                case '*':
                    return luku1 * luku2;
                case '/':
                    if (luku2 == 0)
                    {
                        Console.WriteLine("Nollalla ei voi jakaa");
                        break;
                    }
                    double tot = luku1 / luku2;
                    return tot;
                default:
                    Console.WriteLine("Virheellinen valinta.");
                    break;
            }
            return -1;
        }
    }
}
