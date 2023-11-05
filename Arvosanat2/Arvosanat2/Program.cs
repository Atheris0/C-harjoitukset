using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvosanat2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string arvosana;
            while (true)
            {

                Console.Write("Anna pisteet: ");
                int pisteet = Convert.ToInt32(Console.ReadLine());



                if (pisteet >= 0 && pisteet <= 30)
                {
                    arvosana = "0";
                    Console.WriteLine($"Arvosana on {arvosana}");
                }
                else if (pisteet >= 31 && pisteet <= 40)
                {
                    arvosana = "4";
                    Console.WriteLine($"Arvosana on {arvosana}");
                }
                else if (pisteet >= 41 && pisteet <= 50)
                {
                    arvosana = "5";
                    Console.WriteLine($"Arvosana on {arvosana}");
                }
                else if (pisteet >= 51 && pisteet <= 60)
                {
                    arvosana = "6";
                    Console.WriteLine($"Arvosana on {arvosana}");
                }
                else if (pisteet >= 61 && pisteet <= 70)
                {
                    arvosana = "7";
                    Console.WriteLine($"Arvosana on {arvosana}");
                }
                else if (pisteet >= 71 && pisteet <= 80)
                {
                    arvosana = "8";
                    Console.WriteLine($"Arvosana on {arvosana}");
                }
                else if (pisteet >= 81 && pisteet <= 90)
                {
                    arvosana = "9";
                    Console.WriteLine($"Arvosana on {arvosana}");
                }
                else if (pisteet >= 91 && pisteet <= 100)
                {
                    arvosana = "10";
                    Console.WriteLine($"Arvosana on {arvosana}");
                }
                else if (pisteet == -1)
                {
                    Console.WriteLine("Lopetetaan.");
                    break;
                }
                else
                {
                    arvosana = "Pistemäärän pitää olla välillä 0 - 100.";
                    Console.WriteLine(arvosana);
                }

               
            }
            Console.ReadLine();
        }
    }
}
