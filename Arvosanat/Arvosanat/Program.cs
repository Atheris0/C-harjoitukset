using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvosanat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä pisteet: ");
            int pisteet = Convert.ToInt32(Console.ReadLine());

            string arvosana;

            if (pisteet >= 0 && pisteet <= 30)
            {
                arvosana = "0";
            }
            else if (pisteet >= 31 && pisteet <= 40)
            {
                arvosana = "4";
            }
            else if (pisteet >= 41 && pisteet <= 50)
            {
                arvosana = "5";
            }
            else if (pisteet >= 51 && pisteet <= 60)
            {
                arvosana = "6";
            }
            else if (pisteet >= 61 && pisteet <= 70)
            {
                arvosana = "7";
            }
            else if (pisteet >= 71 && pisteet <= 80)
            {
                arvosana = "8";
            }
            else if (pisteet >= 81 && pisteet <= 90)
            {
                arvosana = "9";
            }
            else if (pisteet >= 91 && pisteet <= 100)
            {
                arvosana = "10";
            }
            else
            {
                arvosana = "Pistemäärän on oltava välillä 0-100.";
            }

            Console.WriteLine(arvosana);
            Console.ReadLine();
        }
    }
}
