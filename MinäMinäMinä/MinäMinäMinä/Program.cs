using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinäMinäMinä
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nimi = "Bilgesu";
            int i = 0;
            do
            {
                Console.Write(nimi);
                i++;
            } while (i < 5);

            Console.ReadLine();

        }
    }
}
