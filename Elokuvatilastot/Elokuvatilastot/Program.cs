using System;

namespace ElokuvaTiedot
{
    class Program
    {
        static void Main(string[] args)
        {
            //tehdään parhaat elokuvat olio
            ParhaatElokuvat movieNight = new ParhaatElokuvat();
            //se palauta elokuva, tehdään toinen elokuva olio
            Elokuva leffa1 = movieNight.ParasElokuva();
            //tulostetaan paras elokuvan ohjaaja
            Console.WriteLine(leffa1.Ohjaaja);
            //viidentenäkymmenentenä olevan elokuvan nimi
            Elokuva leffa50 = movieNight.HaeElokuvaPaikasta(50);
            Console.WriteLine(leffa50.Nimi);
            //elokuvien lukumäärä, jotka on julkaistu samana vuonna kuin listan kärjessä oleva elokuva
            Console.WriteLine(movieNight.ElokuvienMaaraPerVuosi(leffa1.JulkaisuVuosi));
            //parhaan 1990-luvulla tehdyn elokuvan nimi
            Console.WriteLine((movieNight.ParasVuosilta(1990,2000)).Nimi);
            //parhaan 90-luvun elokuvan sijoitus
            Console.WriteLine((movieNight.Sijoitus(movieNight.ParasVuosilta(1990, 2000))));

            Console.ReadKey();

        }
    }
}
