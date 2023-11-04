using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarjesta
{
    internal class Jarjesta
    {
        static void Main(string[] args)
        {
            int paivamaara, lampo;
            String viikonpaiva, kuu;
            lampo = 17;
            viikonpaiva = "Tiistai";
            kuu = "elo";
            paivamaara = 16;

            Console.Write("Tänään on " + viikonpaiva + " ");
            Console.WriteLine("{0}. {1}kuuta.", paivamaara, kuu);
            Console.WriteLine();
            Console.WriteLine("Lämmintä on " + lampo + " astetta.");
            Console.ReadKey();

        }
    }
}


        


        


