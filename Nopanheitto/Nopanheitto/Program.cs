using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nopanheitto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char valinta;
            int heitto;

            while (true)
            {
                valinta = KysyJatko();
                if (valinta == 'e' )
                {
                    break;
                }
                else if (valinta == 'k')
                {
                    heitto = rnd.Next(1, 7);
                    Console.WriteLine($"Heitit {heitto}");
                }
            }
            Console.ReadLine();
        }

        static char KysyJatko()
        {
            char valinta;
            string luettu;
            bool onnistuiko;

            do
            {
                Console.WriteLine("Heitätkö uudelleen? (k - kyllä, e - ei): ");
                luettu = Console.ReadLine();
                onnistuiko = char.TryParse(luettu, out valinta);
                if (onnistuiko != true)
                {
                    Console.WriteLine("Syöte ei kelpaa merkiksi, yritä uudelleen.");
                }
                else if (valinta != 'k' && valinta != 'e')
                {
                    Console.WriteLine("Valinnan pitää olla k tai e. Yritä uudelleen.");
                }
            } while (!onnistuiko && valinta != 'k' && valinta != 'e');

            return valinta;
        }

    }
}
