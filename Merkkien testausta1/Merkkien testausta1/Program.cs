using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkien_testausta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna merkkejä");
            string merkit = Console.ReadLine();
            
            foreach (char merkki in merkit)
                if (char.IsLower(merkki))
                {
                    Console.WriteLine($"{merkki} on pieni kirjain");
                }
                else if (char.IsUpper(merkki))
                {
                    Console.WriteLine($"{merkki} on iso kirjain");
                }
                else if (char.IsDigit(merkki))
                {
                    Console.WriteLine($"{merkki} on numero");
                }
                else if (char.IsPunctuation(merkki))
                {
                    Console.WriteLine($"{merkki} on välimerkki");
                }
                else if (char.IsWhiteSpace(merkki))
                {
                    Console.WriteLine($"{merkki} on tyhjä merkki");
                }
                else
                {
                    Console.WriteLine("Mikälie merkki");
                }
            Console.ReadLine();
        }
    }
}
