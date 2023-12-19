using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kortit on numeroitu 1 - 5.\nVoit vaihtaa enintään 5.");
            //Uusi peli
            Poker newGame = new Poker();
            //Lisää peliin ainakin yksi käsi jollekin pelaajalle
            newGame.LisaaTyhjaKasi("Mikki");
            newGame.LisaaTyhjaKasi("Hessu");
            //Jaa peliin kortit
            newGame.JaaKortit();
            //Tyhjä käsiä sisältävä lista ja hae siihen pelin kädet
            List<Kasi> kadet = newGame.Kadet;
            string luettu;
            string[] tekstina;
            List<Kortti> poistettavat;
            foreach (Kasi kasi in kadet)
            {
                //käden omistaja ja kortit
                Console.WriteLine(kasi.Pelaaja);
                Console.WriteLine(kasi);
                Console.WriteLine("Anna poistettavat");
                //kädestä poistettavien korttien paikat ja lista poistettavista korttiolioista
                luettu = Console.ReadLine();
                tekstina = luettu.Split();
                //Poistetaan vuorossa olevasta kädestä listalla olevat kortit.
                poistettavat = new List<Kortti>();
                Kortti pois;
                foreach (string teksiLuku in tekstina)
                {
                    pois = kasi.HaeKorttiPaikasta(int.Parse(teksiLuku));
                    poistettavat.Add(pois);
                }
                foreach (Kortti poistettava in poistettavat)
                {
                    kasi.PoistaKortti(poistettava);
                }
            }
            //Jaa kortit, jotta kädet täyttyvät
            newGame.JaaKortit();
            foreach (Kasi kasi in kadet)
            {
                //tuo taas näytölle käsien sisällöt
                Console.WriteLine(kasi.Pelaaja);
                Console.WriteLine(kasi);
            }
                Console.ReadLine();



        }
    }
}
