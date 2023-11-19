using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkijonoesimerkki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string etunimi;
            string sukunimi;


            etunimi = "Heikki";
            sukunimi = "Virtanen";

            //Antaa merkkijonon pituuden
            //Console.WriteLine(etunimi.Length);

            ////kertoo, löytyykö merkkijonosta annettu pätkä
            //Console.WriteLine(etunimi.Contains("kk"));

            ////Kertoo, loppuuko merkkijono annettuun pätkään
            //Console.WriteLine(sukunimi.EndsWith("nen"));

            ////Palauttaa annetun pätkän viimeisen sijainnin alkukohdan
            //Console.WriteLine(etunimi.LastIndexOf("ei"));

            ////Palauttaa kohdan merkkijonosta, mistä löytyi ensimmäinen annettu pätkä
            //Console.WriteLine(etunimi.IndexOf("e"));

            ////Tarkastaa alkaako merkkijono annetulla pätkällä
            //Console.WriteLine(etunimi.StartsWith("S"));

            ////Vertaa kahta merkkijonoa ja palauttaa true, jos samat ja false, jos eri
            //Console.WriteLine(etunimi.Equals(sukunimi));

            ////Merkkijonojen järjestysvertailu. Palauttaa 
            ////0 jos samat
            ////<0 jos etunimi aakkosissa ennen sukunimeä
            ////>0 jos sukunimi on aakkosissa ennen etunimeä tai etunimi on null
            //Console.WriteLine(etunimi.CompareTo(sukunimi));

            ////Muuttaa merkkijono pieniksi kirjaimiksi            
            //Console.WriteLine(etunimi.ToLower());

            ////Muuttaa merkkijonon isoiksi kirjaimiksi
            //Console.WriteLine(etunimi.ToUpper());

            //// kopioi merkkijonon
            //string kopio;
            //kopio = (String)etunimi.Clone();

            ////Lisää merkkijonon annettuun kohtaan annetun pätkän
            //kopio = etunimi.Insert(0, "Hei ");
            //Console.WriteLine(kopio);

            ////Poistaa annetusta kohdasta alkaen annetun määrän merkkejä
            //Console.WriteLine(kopio.Remove(4, 3));

            //// korvaa merkkijonossa ensimmäisenä annetun merkin toisena annetulla
            //Console.WriteLine(kopio.Replace('e', 'i'));

            ////Jakaa merkkijonon osiin annetun ehdon kohdalta
            //kopio = etunimi + ' ' + sukunimi;
            //Console.WriteLine(kopio);
            //string[] split = kopio.Split(new char[] { ' ' });


            //Console.WriteLine(split[0]);
            //Console.WriteLine(split[1]);

            ////Palauttaa merkkijonosta pätkän, joka alka ensimmäisen luvun kohdalta
            ////ja loppuu toisen luvun kohdalle
            //Console.WriteLine(kopio.Substring(2, 5));

            ////Muuttaa merkkijonon merkkitaulukoksi
            //Console.WriteLine(etunimi.ToCharArray());

            ////Poistaa merkkijonon alusta ja lopusta tyhjät
            //kopio = "  pari sanaa rivillä  ";
            //Console.WriteLine(kopio.Trim());

            Console.ReadLine();
        }
    }
}
