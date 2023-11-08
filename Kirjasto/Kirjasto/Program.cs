using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjasto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kirjasto kirjasto = new Kirjasto("Kutuphane");

            //luodaan uusi kirjaa
            Kirja lotr = new Kirja("The Lord of the Rings", "J. R. R. Tolkien", "George Allen & Unwin", 1954, "978-0-618-34641-5");
            /*Console.WriteLine("Title: " + lotr.HaeNimi());
            Console.WriteLine("Author: " + lotr.HaeTekija());
            Console.WriteLine("Publisher: " + lotr.HaeJulkaisija());
            Console.WriteLine("Publication Year: " + lotr.HaeJulkaisuVuosi());
            Console.WriteLine("ISBN: " + lotr.HaeISBN());*/

            //toinen kirja
            Kirja harryPotter = new Kirja("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "Bloomsbury Publishing", 1997, "978-0-7475-3269-6");
            /*Console.WriteLine("\nTitle: " + harryPotter.HaeNimi());
            Console.WriteLine("Author: " + harryPotter.HaeTekija());
            Console.WriteLine("Publisher: " + harryPotter.HaeJulkaisija());
            Console.WriteLine("Publication Year: " + harryPotter.HaeJulkaisuVuosi());
            Console.WriteLine("ISBN: " + harryPotter.HaeISBN());*/
            Kirja prideAndPrejudice = new Kirja("Pride and Prejudice", "Jane Austen", "T. Egerton", 1813, "978-0-19-283355-6");
            Kirja toKillAMockingbird = new Kirja("To Kill a Mockingbird", "Harper Lee", "J. B. Lippincott & Co.", 1960, "978-0-06-112008-4");

            //lisätään kirjoja
            kirjasto.LisaaKirjoja(lotr);
            kirjasto.LisaaKirjoja(harryPotter);
            kirjasto.LisaaKirjoja(prideAndPrejudice);
            kirjasto.LisaaKirjoja(toKillAMockingbird);

            //poistetaan kirja
            kirjasto.PoistaKirja(prideAndPrejudice);
            //listataan kaikki kirjat paitsi poistetu kirja
            kirjasto.kirjatListattu();

            //tulostetaan kirjan nimi tekijän nimellä
            //Console.WriteLine(kirjasto.TulostaaKirja(kirjasto.HaeKirjaTekijalla("Jane Austen")));
            


            Console.ReadLine();
        }
    }
}
