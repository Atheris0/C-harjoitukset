using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Henkilöauto : Auto
    {
        int henkilomaara;
        double polttoaineenKulutus;
        public Henkilöauto(string merkki, string malli, int vuosimalli, double hinta, int henkilomaara, double polttoaineenKulutus)
            : base (merkki, malli, vuosimalli, hinta)
        {
            this.henkilomaara = henkilomaara;
            this.polttoaineenKulutus = polttoaineenKulutus;
        }

        public int Henkilomaara { get { return henkilomaara; } set {  henkilomaara = value; } }
        public double PolttoaineenKulutus {  get { return polttoaineenKulutus; } set{ polttoaineenKulutus = value; } }
    }

    public class Pakettiauto : Auto
    {
        int tavaratilaKoko;
        string tyyppi;
        public Pakettiauto(string merkki, string malli, int vuosimalli, double hinta, int tavaratilaKoko, string tyyppi)
            : base(merkki, malli, vuosimalli, hinta)
        {
            this.tavaratilaKoko = tavaratilaKoko;
            this.tyyppi = tyyppi;
        }

        public int TavaratilaKoko { get { return tavaratilaKoko; } set { tavaratilaKoko = value; } }
        public string Tyyppi { get { return tyyppi; } }
        
    }

    public class KuormaAuto : Auto
    {
        double kuormaKapasiteetti;
        double kuormaTilaKoko;
        public KuormaAuto(string merkki, string malli, int vuosimalli, double hinta, double kuormaKapasiteetti, double kuormaTilaKoko)
            : base(merkki, malli, vuosimalli, hinta)
        {
            this.kuormaKapasiteetti = kuormaKapasiteetti;
            this.kuormaTilaKoko = kuormaTilaKoko;
        }

        public double KuormaKapasiteetti { get { return kuormaKapasiteetti; } set { kuormaKapasiteetti = value; } }
        public double KuormaTilaKoko { get { return kuormaTilaKoko; } set { kuormaTilaKoko = value; } }

    }
}
