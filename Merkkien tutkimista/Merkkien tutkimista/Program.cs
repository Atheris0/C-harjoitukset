using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkien_tutkimista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku;
            using (StreamReader lukuTiedosto = new StreamReader("merkkitiedosto.txt"))
            {
                while ((luku = lukuTiedosto.Read()) != -1)
                {
                    char merkki = (char)luku;
                    if (char.IsUpper(merkki))
                    {
                        Console.WriteLine($"{merkki} on iso kirjain.");
                    }
                    else if (char.IsLower(merkki))
                    {
                        Console.WriteLine($"{merkki} on pieni kirjain.");
                    }
                    else if (char.IsPunctuation(merkki))
                    {
                        Console.WriteLine($"{merkki} on välimerkki.");
                    }
                    else if (char.IsDigit(merkki))
                    {
                        Console.WriteLine($"{merkki} on numero.");
                    }
                    else if (char.IsWhiteSpace(merkki))
                    {
                        Console.WriteLine($"{merkki} on välilyöntimerkki.");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
