using System;
using System.Drawing;

namespace Sanalomake
{
    class Sanataulukko
    {
        string[] sanat;
        int sanoja;

        public Sanataulukko()
        {
            sanat = new string[100];
            sanoja = 0;
        }
        //LisaaSana, joka lisää parametrina tulevan sanan sanataulukkoon.
        public void LisaaSana(string sana)
        {
            sanat[sanoja] = sana;
            sanoja++;
        }
        //HaeSanat, joka palauttaa sanataulukon
        public string[] HaeSanat()
        {
            return sanat;
        }
        //HaeKaanteinen, joka palauttaa sanataulukon sanat käänteisessä järjestyksessä uudessa sanataulukossa
        public string[] HaeKaanteinen()
        {
            string[] kaanteinen = new string[100];
            for (int i = 0; i < sanoja; i++)
            {
                kaanteinen[i] = sanat[sanoja - 1 - i];
            }
            return kaanteinen;
        }
    }
}
