using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salasana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string oikeaSalasana = "moppe";
            string annettuSalasana;

            do
            {
                Console.Write("Anna salasana: ");
                annettuSalasana = Console.ReadLine();

                if (annettuSalasana == oikeaSalasana)
                {
                    Console.WriteLine("Onnistui");
                }
                
            } while (annettuSalasana != oikeaSalasana);

            Console.ReadLine();
        }
    }
}
