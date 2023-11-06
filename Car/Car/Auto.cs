using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Auto
    {
        public string merkki;
        public string malli;
        public int vuosimalli;
        public double hinta;

        public Auto(string merkki, string malli, int vuosimalli, double hinta)
        {
            this.merkki = merkki;
            this.malli = malli;
            this.vuosimalli = vuosimalli;
            this.hinta = hinta;
        }
        public string Merkki { get {  return merkki; } }
        public string Malli { get {  return malli; } }
        public int Vuosimalli { get { return vuosimalli; } }
        public double Hinta { get {  return hinta; } }
    }
}
