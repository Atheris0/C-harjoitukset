using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjasto
{
    internal class Kirjasto
    {
        //Kirjastolla on nimi ja lista siellä olevista kirjoista. 
        string kirjastonNimi;
        private List<Kirja> kirjat;
        public Kirjasto(string annettuNimi)
        {
            kirjastonNimi = annettuNimi;
            kirjat = new List<Kirja>();
        }

        //kirjaston nimi
        public string KirjastonNimi()
        {
            return kirjastonNimi;
        }
        public void kirjatListattu()
        {
            foreach (var item in kirjat)
            {
                Console.WriteLine(item.HaeNimi());
            }
        }

        //Kirjastoon pitää pystyä lisäämään kirjoja
        public void LisaaKirjoja(Kirja kirja)
        {
            kirjat.Add(kirja);
        }

        //Kirjastoon pitää hakemaan kirjaa tekijän nimellä
        public Kirja HaeKirjaTekijalla(string tekija)
        {
            return kirjat.Find(x => x.HaeTekija() == tekija);
        }

        //Kirjastoon pitää tulostamaan kirjan tiedot
        public string TulostaaKirja(Kirja kirja)
        {
            return string.Format("Kirjan nimi {0}, kirjan tekijä {1}", kirja.HaeNimi(), kirja.HaeTekija());
        }

        //Kirjastosta pitää pystyä poistamaan tietty kirja kirjan nimen perusteella
        public void PoistaKirja(Kirja kirja)
        {
            kirjat.Remove(kirja);
        }
    }
}
