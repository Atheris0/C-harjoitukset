using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jäsenrekisteri
{
    internal class Jasen
    {
        string sukunimi;
        string etunimi;
        string lahiosoite;
        string postitoimipaikka;
        int postinumero;
        int liittymisvuosi;
        public List<Maksu> Maksut { get; set; } = new List<Maksu>();

        /// <summary>
        /// Jäsenestä tiedetään suku- ja etunimi, lähiosoite, postitoimipaikka ja -numero, sekä liittymisvuosi. 
        /// </summary>
        /// <param name="sukunimi"></param>
        /// <param name="etunimi"></param>
        /// <param name="lahiosoite"></param>
        /// <param name="postitoimipaikka"></param>
        /// <param name="postinumero"></param>
        /// <param name="liittymisvuosi"></param>
        public Jasen(string sukunimi, string etunimi, string lahiosoite, string postitoimipaikka, int postinumero, int liittymisvuosi)
        {
            this.sukunimi = sukunimi;
            this.etunimi = etunimi;
            this.lahiosoite = lahiosoite;
            this.postitoimipaikka = postitoimipaikka;
            this.postinumero = postinumero;
            this.liittymisvuosi = liittymisvuosi;
        }
        public string Sukunimi { get {  return sukunimi; } }
        public string Etunimi { get { return etunimi; } }
        public string Lahiosoite { get {  return lahiosoite; } }
        public int Postinumero { get {  return postinumero; } }
        public string Postitoimipaikka { get {  return postitoimipaikka; } }
        public int Liittymisvuosi { get { return liittymisvuosi; } }
    }
}
