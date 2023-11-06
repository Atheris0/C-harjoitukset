using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jäsenrekisteri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rekisteri rekisteri = new Rekisteri();
            Jasen bibe = new Jasen("Mrt", "Bilge", "Haapanankuja 3", "Imatra", 55400, 2012);
            rekisteri.LisaaJasen(bibe);
            Jasen markusu = new Jasen("Vihainen", "Marko", "Terassiskonkuja", "Imatra", 55112, 2012);
            rekisteri.LisaaJasen(markusu);
            Jasen belgin = new Jasen("Mrt", "Belgin", "Corlu", "Tekirdag", 12345, 2012);
            rekisteri.LisaaJasen(belgin);

            //lisäätään jäsenen maksu
            Maksu maksu1 = new Maksu(2012, 12, 209.99, "Bilge Mrt");
            rekisteri.LisaaMaksu(bibe, maksu1);
            Maksu maksu2 = new Maksu(2012, 12, 209.99, "Marko Viha");
            rekisteri.LisaaMaksu(markusu, maksu2);
            Maksu maksu3 = new Maksu(2022, 12, 209.99, "Bilge Mrt");
            rekisteri.LisaaMaksu(bibe, maksu3);
            Maksu maksu4 = new Maksu(2022, 12, 209.99, "Marko Viha");
            rekisteri.LisaaMaksu(markusu, maksu4);
            Maksu maksu5 = new Maksu(2022, 12, 209.99, "Belgin Mrt");
            rekisteri.LisaaMaksu(belgin, maksu5);


            //hakemaan ne, jotka eivät ole vielä maksaneet annetun vuoden jäsenmaksua
            List<Jasen> maksamattomat = rekisteri.HaeMaksamattomatJäsenet(2012);
            Console.WriteLine("Maksamattomat jäsenet vuodelle: ");
            foreach (var jäsen in maksamattomat)
            {
                Console.WriteLine($"{jäsen.Etunimi} {jäsen.Sukunimi}");
            }
            Console.ReadLine();

        }
    }
}
