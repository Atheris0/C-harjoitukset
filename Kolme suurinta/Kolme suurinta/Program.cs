using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolme_suurinta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku;
            string teksti;
            List<int> lista = new List<int>();

            while (true)
            {
                //kysytään luvut

                Console.WriteLine("Anna kokonaislukuja. Lopeta -1:lla");
                teksti = Console.ReadLine();

                //tarkistetaan jos teksti on -1

                if (teksti == "-1") {
                    break;
                } else
                {
                    luku = int.Parse(teksti);
                    lista.Add(luku);
                }
            }

            //tulostaa listan

            Console.Write("Luvut: ");

            foreach (int item in lista)
            {
                Console.Write(item + " ");

            };

            Console.WriteLine();
            //jäsjestää listan pienimmästä suurimpaan
            lista.Sort();
            
            Console.Write("Kolme suurinta ovat: ");
            //tulostaa kolme viimeistä lukua

            Console.Write(lista[lista.Count - 1] + " ");
            Console.Write(lista[lista.Count - 2] + " ");
            Console.Write(lista[lista.Count - 3]);

            Console.ReadKey();
        }
    }
}
