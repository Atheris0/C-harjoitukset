using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukon_esimerkki
{
    public class Taulukko
    {
        //Kokonaislukutaulukko lukuja varten
        private int[] taulukko;
        //Montako lukua taulukkoon mahtuu
        private int taulukonKoko;
        //Mihin kohtaan uusi alkio laitetaan
        private int indeksi;

        //koko on luotavan taulukon koko
        public Taulukko(int koko)
        {
            //Luo uusi taulukko, jonka koko on koko
            //Ota koko talteen jäsenmuuttujaan
            //Alusta indeksi nollaksi
            taulukko = new int[koko];
            taulukonKoko = koko;
            indeksi = 0;
        }

        //Lisää parametrina tulevan luvun taulukon viimeiseksi
        public bool Lisaa(int luku)
        {
            //Jos taulukko on jo täysi, ei lisätä, vaan palautetaan false
            //Jos on tilaa, lisätään, siirretään indeksiä yhdellä eteenpäin ja palautetaan true 
            if (indeksi < taulukonKoko)
            {
                taulukko[indeksi] = luku;
                indeksi += 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Laskee taulukkoon lisättyjen lukujen keskiarvon ja palauttaa sen
        public double LaskeKeskiarvo()
        {
            //Jos taulukko on tyhjä, palauta 0
            //Laske taulukon lukujen keskiarvo (vain ne, jotka on lisätty, ei täytenollia)
            //Palauta keskiarvo
            double summa = 0;
            int maara = 0;

            if (indeksi == 0)
            {
                return 0;
            }
            for (int i = 0; i < indeksi; i++)
            {
                summa += taulukko[i];
                maara++;
            }
            return summa / maara;
        }

        //Palauttaa taulukon suurimman alkion
        public int HaeSuurin()
        {
            //Jos taulukko on tyhjä, palauttaa 0
            //Hae suurin ja palauta se
            if (indeksi == 0)
            {
                return 0;
            }
            int suurin = taulukko[0];
            for (int i = 0; i < indeksi; i++)
            {
                if (suurin < taulukko[i])
                {
                    suurin = taulukko[i];
                }
            }
            return suurin;
        }

        // tulostaa taulukon luvut peräjälkeen riville
        public void Tulosta()
        {
            //tulosta vain lisätyt luvut, ei täytenollia
            for (int i = 0; i < indeksi; i++)
            {
                Console.Write("{0} ", taulukko[i]);
            }
            Console.WriteLine();
        }
    }
}