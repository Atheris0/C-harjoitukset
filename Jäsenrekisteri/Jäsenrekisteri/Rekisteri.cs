using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jäsenrekisteri
{
    internal class Rekisteri
    {
        List<Jasen> jasenet = new List<Jasen>();

        public void LisaaJasen(Jasen jasen)
        {
            jasenet.Add(jasen);
        }
        public void PoistaJasen(Jasen jasen)
        {
            jasenet.Remove(jasen);
        }
        public void LisaaMaksu(Jasen jäsen, Maksu maksu)
        {
            jäsen.Maksut.Add(maksu);
        }

        public double LaskeJäsenmaksujenSumma(int vuosi)
        {
            return jasenet
                .SelectMany(j => j.Maksut)
                .Where(m => m.Maksuvuosi == vuosi)
                .Sum(m => m.Maksumaara);
        }

        //hakemaan ne, jotka eivät ole vielä maksaneet annetun vuoden jäsenmaksua
        public List<Jasen> HaeMaksamattomatJäsenet(int vuosi)
        {
            return jasenet.Where(j => j.Maksut.All(m => m.Maksuvuosi != vuosi)).ToList();
        }
    }
}
