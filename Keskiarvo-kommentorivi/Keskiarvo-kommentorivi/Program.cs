using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keskiarvo_kommentorivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku = 0;
            int total = 0;

            foreach (string item in args)
            {
                luku = int.Parse(item);
                total = total + luku;

            }
            double keskiarvo = (double)total / args.Length;
            Console.WriteLine("Keskiarvo on " + keskiarvo);
            Console.ReadLine();
        }
    }
}
