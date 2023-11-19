using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkijonoesimerkki
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Anna teksti: ");
            string teksti = Console.ReadLine();

            //Merkkijonon pituus
            Console.WriteLine(teksti.Length);

            ////ensimmäinen merkki
            Console.WriteLine(teksti[0]);

            ////loppuuko teksti kirjaimiin lu
            Console.WriteLine(teksti.EndsWith("lu"));

            ////onko tekstissä pätkä ie
            Console.WriteLine(teksti.Contains("ie"));

            ////missä kohtaa on p
            Console.WriteLine(teksti.IndexOf("p"));

            ////Poistaa merkkijonon alusta ja lopusta tyhjät
            Console.WriteLine(teksti.Trim());

            ////korvaa kaikki r-kirjaimet kirjaimella l
            Console.WriteLine(teksti.Replace('r', 'l'));

            ////lisää alkuun tyhjiä niin paljon, että tekstin pituus on 30 merkkiä
            Console.WriteLine(teksti.PadLeft(30));

            Console.ReadLine();
        }
    }
}
