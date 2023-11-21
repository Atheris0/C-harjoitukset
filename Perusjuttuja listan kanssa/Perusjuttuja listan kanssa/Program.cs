using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perusjuttuja_listan_kanssa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(11);
            lista.Add(22);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);

            //Listan pituus
            //Console.WriteLine(lista.Count);

            //Kohdassa 2 olevan arvon
            //Console.WriteLine(lista[2]);
            
            //korvaa viimeisen arvolla 100
            lista[lista.Count -1] = 100;

            //lisää loppuun luvut 32 ja 0
            lista.AddRange(new List <int> {32, 0});

            //tarkista, löytyykö listasta lukua 5
            //Console.WriteLine(lista.Contains(5));

            //hae ensimmäinen arvo, joka on pienempi kuin 10
            //Console.WriteLine(lista.FindIndex(x => x < 10));

            //hakee kaikki luvut, jotka ovat suurempia kuin 20
            /*
            List<int> suuremmatKuin20 = lista.FindAll(x => x > 20);
            foreach (int luku in suuremmatKuin20)
            {
                Console.WriteLine(luku);
            }
            */

            //Lisää kohtaan 0 luvun 7 ja tulostaa listan tämän jälkeen.
            lista.Insert(0, 7);
            /*
            foreach (int luku in lista)
            {
                Console.WriteLine(luku);
            } 
            Console.ReadLine(); */

            //Poistaa kaikki kymmentä suuremmat luvut ja tulostaa listan tämän jälkeen.
            lista.RemoveAll(x => x < 10);
            /*
            foreach (int luku in lista)
            {
                Console.WriteLine(luku);
            }
            Console.ReadLine(); */

            //Poistaa luvun kohdasta 1 ja tulostaa listan.
            lista.RemoveAt(1);
            foreach (int luku in lista)
            {
                Console.WriteLine(luku);
            }
            Console.ReadLine();

        }
    }
}
