using System;


namespace Papukaija
{
    class PapukaijaTesti
    {
        static void Main()
        {
            Papukaija eka = new Papukaija("Polli", "kirjava");
            Console.WriteLine(eka);
            Console.WriteLine(eka.Puhu());
            eka.OpiLause("Silliä pöytään");

            //ToDo: Luo lisää papukaijoja ja opeta niitä puhumaan
            Papukaija toka = new Papukaija("Mavis", "sininen");
            Console.WriteLine(toka);
            Console.WriteLine(toka.Puhu());
            toka.OpiLause("Cici kus");

            Console.ReadLine();
        }
    }
}
