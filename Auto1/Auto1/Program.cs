using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto1
{
    class AutoTesti
    {
        static void Main()
        {
            Auto kulkuneuvo, kaara;
            // Luodaan uusi Auto-olio ja tulostetaan sen kuvaus
            kulkuneuvo = new Auto("Volkkari", "Corola");
            Console.WriteLine(kulkuneuvo.AnnaKuvaus());

            // Lisätään auton matkamittariin 10 km ja tulostetaan sen kuvaus uudestaan
            kulkuneuvo.LisaaMatka(10);
            Console.WriteLine(kulkuneuvo.AnnaKuvaus());

            // Luodaan toinen ilmentymä Auto-luokasta ja tulostetaan sen kuvaus
            kaara = new Auto("Sitikka", "Elf");
            Console.WriteLine(kaara.AnnaKuvaus());

            // Lisätään taas matka ensimmäisenä luodun olion matkamittariin ja tulostetaan kuvaus uudelleen
            kulkuneuvo.LisaaMatka(5);
            Console.WriteLine(kulkuneuvo.AnnaKuvaus());

            // Lopuksi tulostetaan vielä toisen auto-olion kuvaus. Tämän olion matkamittarin 
            // lukema on edelleen nolla:
            Console.WriteLine(kaara.AnnaKuvaus());

            //esimerkki

            kulkuneuvo.MuutaOmistaja("Alice");
            kulkuneuvo.Huolla(new DateTime(2025, 12, 31));
            Console.WriteLine(kulkuneuvo.HaeHuollot());
            Console.WriteLine(kulkuneuvo.AnnaKuvaus());
            


            Console.ReadLine();
        }
    }
}
