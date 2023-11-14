using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lukujen_tulostus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> luvut = new List<double> {
            0.17503, 0.04882, 0.96687, 0.88125, 0.55995, 0.79356, -0.15694, 0.50399, 0.93578, 0.70812,
            0.09323, -0.38114, 0.60691, 0.38750, 0.74225, 0.09535, -0.60773, -0.92170, 0.90609, 0.22022,
            0.85020, 0.69113, 0.38952, 0.30950, -0.33392, 0.87190, 0.60288, 0.12522, 0.75659, 0.08993,
            0.15528, 0.25628, 0.93481, 0.72978, 0.21553, 0.48456, 0.80043, -0.02879, 0.37817, 0.50712,
            -0.82730, 0.46158, 0.00068, 0.21993, 0.46496, 0.05868, -0.20698, 0.70297, 0.52609, 0.07589,
            0.27732, 0.18599, -0.66648, 0.84109, 0.31842, 0.47559, 0.25329, 0.60100, 0.45323, 0.59490,
            0.69024, 0.05755, 0.53711, 0.06744, 0.95903, 0.80972, 0.71092, 0.91866, 0.19127, 0.32974,
            0.89160, -0.96296, -0.04862, 0.99409, -0.22820, 0.39461, 0.85606, 0.05865, 0.18399, 0.83589,
            0.81314, 0.14231, 0.19188, -0.31890, 0.44471, 0.96215, 0.43080, -0.99438, 0.26252, 0.22177,
            0.79915, 0.67356, -0.54431, 0.35000, 0.62022, -0.72232, 0.46017, 0.87173, 0.40359, 0.71786 };

            int counter = 0;
            foreach (double luku in luvut)
            {
                //Kerro luku 100:lla
                double tulos = luku * 100;
                // Muotoile ja tulosta numero seitsemän merkin pituiseen kenttään oikeaan tasauksella
                Console.Write(tulos.ToString().PadLeft(8));
                counter++;
                // Tarkistus, täytyykö meidän aloittaa uusi rivi (kymmentä numeroa riviä kohden)
                if (counter % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
