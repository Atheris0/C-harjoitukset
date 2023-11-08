using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi_paperi_sakset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valinta;
            string teksti;

            while (true)
            {
                Console.Write("Valinnat:\nEnter - lopeta\n1- kivi\n2- sakset\n3- paperi\nMikä on valintasi: ");
                
                teksti = Console.ReadLine();    // Lue pelaajan syöttämä teksti
                if (teksti == string.Empty)     // Lopeta silmukka, jos syöte on Enter
                { break; }
                else
                {
                    valinta = int.Parse(teksti);
                    if (valinta > 3 || valinta < 1)
                    { 
                        Console.WriteLine("Väärin valinta");
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                    else
                    {
                        int konenValinta = KoneValitse();
                        Console.WriteLine($"Kone valitsi {konenValinta}");
                        Console.WriteLine(KukaVoitti(valinta, konenValinta));
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }

            }
            
            
        }
        // Tarkistaa, kuka voitti
        static string KukaVoitti(int valinta, int konenValinta) 
    {
        if (valinta == 1 && konenValinta == 2)
        {
            return "Voitit";
        }
        else if (valinta == 2 && konenValinta == 3)
        {
            return "Voitit";
        }
        else if (valinta == 3 && konenValinta == 1)
        {
            return "Voitit";
        }
        else if (valinta == konenValinta)
        {
            return "Tasapeli";
        }
        else
        {
            return "Hävisit";
        }

    }
        // Tietokoneen valinta
        static int KoneValitse()
    {
        Random rnd = new Random();
        int randy = rnd.Next(1, 4);     // Generoi satunnainen luku välillä 1-3

            return randy;
    }

    }
}
