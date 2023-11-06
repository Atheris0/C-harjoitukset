using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jäsenrekisteri
{
    internal class Maksu
    {
        int maksuvuosi;
        int maksupaiva;
        double maksumaara;
        string maksaja;

        /// <summary>
        /// Maksusta pitää ilmoittaa minkä vuoden maksua se on, maksupäivä ja määrä sekä maksaja.
        /// </summary>
        /// <param name="maksuvuosi"></param>
        /// <param name="maksupäivä"></param>
        /// <param name="maksumaara"></param>
        /// <param name="maksaja"></param>

        public Maksu(int maksuvuosi, int maksupäivä, double maksumaara, string maksaja)
        {
            this.maksuvuosi = maksuvuosi;
            this.maksupaiva = maksupäivä;
            this.maksumaara = maksumaara;
            this.maksaja = maksaja;
        }

        public int Maksuvuosi { get { return maksuvuosi; } }
        public int Maksupaiva { get { return maksupaiva; } }
        public double Maksumaara { get {  return maksumaara; } }
        public string Maksaja { get { return maksaja; } }
    }
}
