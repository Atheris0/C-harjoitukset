using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vesilaskuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //veden tarkistus
            Console.Write("Paljonko vettä on jäljellä? ");
            double vesiMaara = tarkistOMeter();

            //litran tarkistus
            Console.Write("Monta litraa vettä kuluu tunnissa? ");
            double vettaKuluu = tarkistOMeter();

            //kilometrin tarkistus
            Console.Write("Monta kilometriä tunnissa etenet? ");
            double kmMaara = tarkistOMeter();

            //kilometriä jäljellä
            Console.Write("Monta kilometriä on jäljellä? ");
            double kmJaljella = tarkistOMeter();
            //Aikaa jäljellä
            double matkaTunti = kmJaljella / kmMaara;
            //Aika minuutteina
            double matkaMinuutti = kmJaljella / kmMaara * 60;
            //Paljonko vettä tarvitaan matkaan
            double vesiTarve = matkaTunti * vettaKuluu;
            //Riittääkö vesi
            double vettaTarvitaan = vesiMaara - vesiTarve;
           
            int tunti = Convert.ToInt32(matkaMinuutti) / 60;
            int min = Convert.ToInt32(matkaMinuutti) - 60 * tunti;
            Console.WriteLine("Matkaan menee aikaa noin {0} tuntia {1} minuuttia.", tunti, min);

            if (vettaTarvitaan > 0) 
            {
                Console.WriteLine($"Vesi riittää, yli jää {vettaTarvitaan:f1} litraa.");
            } else
            {
                vettaTarvitaan = vettaTarvitaan * -1;
                Console.WriteLine($"Etsi jostakin {vettaTarvitaan:f1} litraa vettä.");
            }
            Console.ReadLine();
        }
        static double tarkistOMeter()
        {
            double tarkistettu;
            while (!double.TryParse(Console.ReadLine(), out tarkistettu))
            {
                Console.WriteLine("Virheellinen syöte. Syötä kelvollinen luku.");
            }
            return tarkistettu;
        }
    }
}
