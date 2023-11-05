using System;
using System.Collections.Generic;

///<summary>
/// Autoluokka. Autolla voi ajaa ja matkamittariin voi
/// lisätä kilometrejä.
///</summary>

namespace Auto1
{ 
    public class Auto
    {
        /// <summary>
        /// Auton matkamittari, int.
        /// </summary>
        private int matkamittari;
        /// <summary>
        /// Auton merkki, string.
        /// </summary>
        private string merkki;
        private string malli;
        private int kilometrit;
        private string omistaja;
        private string rekisteri;
        private List<DateTime> huoltoPaivat;

        /// <summary>
        /// Alustusmetodi. Parametriarvona annettaan luotavan auton merkki.
        /// Uudella autolla on ajettu 0 km.
        /// </summary>
        /// <param name="autonMerkki">Luotavan auton merkki</param>
        public Auto(string autonMerkki, string autonMalli)
        {
            matkamittari = 0;
            merkki = autonMerkki;
            huoltoPaivat = new List<DateTime>();
            malli = autonMalli;
            rekisteri = "";
        }

        /// <summary>
        /// Tämä metodi tulostaa ainoastaan tekstin "Wroom!".
        /// </summary>
        public void Aja()
        {
            Console.WriteLine("Wroom!");
            kilometrit += matkamittari;
        }

        /// <summary>
        /// Tällä metodilla lisätään matka Auto-olion matkamittariin.
        /// </summary>
        /// <param name="matka">Mittariin lisättävä matka. (int)</param>
        public void LisaaMatka(int matka)
        {
            matkamittari += matka;
        }

        /// <summary>
        /// Tämä metodi palauttaa kuvauksen siitä autosta, jonka kautta metodia kutsutaan.
        /// Kuvauksessa näytetään auton malli ja sen matkamittarin lukema.
        /// </summary>
        /// <returns>Kuvaus autosta tekstinä.</returns>
        /// 
        //AnnaKuvaus, joka palauttaa merkkijonona auton merkin, mallin, rekisterinumeron, omistajan ja ajetut kilometrit.
        public string AnnaKuvaus()
        {
            return string.Format("Auton merkki: {0}, malli: {2}, rekisterinumero: {3}, omistaja: {4} ajettu: {1} km.",
                merkki, matkamittari, malli, rekisteri, omistaja);
        }

        //HaeTyyppi, joka palauttaa auton merkin ja mallin merkkijonona
        public string HaeTyyppi()
        {
            return ($"{ merkki}, { malli}");
        }
        //MuutaOmistaja, joka muuttaa omistajan annetuksi
        public void MuutaOmistaja(string uusiOmistaja)
        {
            omistaja = uusiOmistaja;
        }
        //HaeOmistaja, joka palauttaa omistajan
        public string HaeOmistaja()
        {
            return omistaja;
        }
        //MuutaRekisteri, joka vaihtaa rekisterinumeron annetuksi
        public void MuutaRekisteri(string uusiRekisteri)
        {
            rekisteri = uusiRekisteri;
        }
        //HaeRekisteri, joka palauttaa rekisterinumeron
        public string HaeRekisteri()
        {
            return rekisteri;
        }
        //HaeKilometrit, joka palauttaa autolla ajetut kilometrit
        public int HaeKilometrit()
        {
            return kilometrit;
        }
        //Huolla, joka lisää annetun päivämäärän huoltolistaan
        public void Huolla(DateTime huoltoPaiva)
        {
            huoltoPaivat.Add(huoltoPaiva);
        }

        //HaeHuollot, joka muuttaa huoltolistan tekstiksi, jossa päivämäärät ovat allekkain ja palauttaa sen (string).
        public string HaeHuollot()
        {
            string stringattu = "";
            foreach (var item in huoltoPaivat)
            {
                stringattu += item.ToString() + "\n";
            }
            return stringattu;
        }
    }
}