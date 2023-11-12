using System;

namespace KriitikkoTeksti
{
    class KriitikkoTeksti
    {
        static void Main(string[] args)
        {
            // Luo uuden kriitikon, jolla ei ole vielä arvosteluja
            Kriitikko pena = new Kriitikko();

            // Luo uuden leffan. Parametrit: nimi, kommentti, kesto, arvostelu 0-10.
            Leffa leffa1 = new Leffa("Oblivion", "kiva", new TimeSpan(2, 36, 00), 9);

            // Lisää leffan kriitikon arvosteluihin.
            pena.LisaaLeffa(leffa1);
            //Minun kritiikko

            Leffa leffa2 = new Leffa("Oppenheimer", "bombs", new TimeSpan(3, 00, 00), 7);
            pena.LisaaLeffa(leffa2);

            Leffa leffa3 = new Leffa("The Godfather", "mafias", new TimeSpan(2, 55, 00), 10);
            pena.LisaaLeffa(leffa3);

            Leffa leffa4 = new Leffa("Blade Runner 2049", "meh", new TimeSpan(2, 44, 00), 6);
            pena.LisaaLeffa(leffa4);

            Leffa leffa5 = new Leffa("Sharknado", "worst", new TimeSpan(1, 26, 00), 1);
            pena.LisaaLeffa(leffa5);

            Leffa leffa6 = new Leffa("RRR", "o ye", new TimeSpan(3, 07, 00), 8);
            pena.LisaaLeffa(leffa6);

            Console.Write(pena.Suosikki.Nimi);
            Console.Write(" ");
            Console.WriteLine(pena.Suosikki.Pituus);
            int laskuri = 0;

            foreach (var item in pena.Leffat)
            {
                if (item.KannattaakoKatsoa() == true)
                {
                    laskuri++;
                }
            }
            Console.WriteLine($"Arvokas leffojen määrä on: {laskuri}");

            Console.ReadKey();
        }
    }
}
