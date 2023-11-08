using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjasto
{
    internal class Kirja
    {
        //Kirjalla on nimi, tekijä, julkaisija, julkaisuvuosi ja ISBN-numero.
        private string kirjanNimi;
        private string tekija;
        private string julkaisija;
        private int julkaisuVuosi;
        private string ISBNnumero;

        public Kirja(string kirjanNimi, string tekija, string julkaisija, int julkaisuVuosi, string ISBNnumero)
        {
            this.kirjanNimi = kirjanNimi;
            this.tekija = tekija;
            this.julkaisija = julkaisija;
            this.julkaisuVuosi = julkaisuVuosi;
            this.ISBNnumero = ISBNnumero;
        }
        public string HaeNimi()
        {
            return kirjanNimi;
        }

        public string HaeTekija()
        {
            return tekija;
        }

        public string HaeJulkaisija()
        {
            return julkaisija;
        }

        public int HaeJulkaisuVuosi()
        {
            return julkaisuVuosi;
        }

        public string HaeISBN()
        {
            return ISBNnumero;
        }
    }
}
