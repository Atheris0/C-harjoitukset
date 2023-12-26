using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilit
{
    public class PankkiTesti
    {
        static void Main()
        {
            Console.WriteLine("Luodaan testiasiakas.");
            Asiakas asiakas1 = new Asiakas(54321, "Teemu Datanomi");
            Console.WriteLine("Luodaan tili. Sen saldo on nyt:");
            Tili asiakas1Tili = new Tili(asiakas1);
            Console.WriteLine(asiakas1Tili.Saldo);
            Console.WriteLine("Talletetaan vähän rahaa tilille. Saldo on nyt:");
            asiakas1Tili.Talleta(4000);
            Console.WriteLine(asiakas1Tili.Saldo);
            Console.WriteLine("Otetaan rahaa tililtä. Saldo on nyt:");
            asiakas1Tili.Nosta(2500);
            Console.WriteLine(asiakas1Tili.Saldo);
            Console.WriteLine("Otetaan vähän lisää rahaa. Saldo on nyt:");
            asiakas1Tili.Nosta(2000);
            Console.WriteLine(asiakas1Tili.Saldo);
            Console.WriteLine("Luodaan toinen tili samalle asiakkaalle. Sen saldo on nyt:");
            Tili asiakas1Tili2 = new Tili(asiakas1);
            Console.WriteLine(asiakas1Tili.Saldo);
            Console.WriteLine("Siirretään rahaa tokalta tililtä ekalle. Tilien saldot ovat nyt:");
            asiakas1Tili2.SiirraTilille(asiakas1Tili, 1800);
            Console.WriteLine(asiakas1Tili.Saldo);
            Console.WriteLine(asiakas1Tili2.Saldo);
            Console.ReadLine();
        }
    }

}
