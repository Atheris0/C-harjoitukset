using System;

/// <summary>
/// Luokka esittää papupeliä, jossa  on kasa papuja,
/// joista jokainen pelaaja ottaa vuorollaan 1, 2, tai 3 papua.
/// Pelin häviää se, joka joutuu ottamaan viimeisen pavun.
/// Ohjelmasta puuttuvat funktiot papujen ottamiselle.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        //pelaajat ja niiden nimet
        string pelaaja1 = "Pelaaja1";
        string pelaaja2 = "Pelaaja2";
        //vuoronumerot peliin: 0 ja 1
        //pelaaja 1 aloittaa, vuoronumero on 0
        int vuoro = 0;
        //hävinneen pelaajan vuoronumero
        int haviaja;
        //papujen määrä pelin alussa, voi muuttaa
        int papuja = 10;
        //kuinka monta papua pelaaja otti
        int otettu;

        //Pelin silmukka. Kutsutaan kummankin pelaajan ottamisfunktiota.
        //Ottamisen jälkeen tutkitaan jäikö käteen viimeinen papu,
        //jolloin pelaaja hävisi ja toito loppuu.
        while (true)
        {
            //kutsutaan funktiota, joka kysyy otettavien papujen määrän
            otettu = Pelaaja1Ottaa(papuja);
            //vähentää papujen määrää otetuilla
            papuja = papuja - otettu;
            Console.WriteLine("{0} otti {1}: jäljellä {2}.", pelaaja1, otettu, papuja);
            //ottiko pelaaja viimeisen pavun
            if (papuja == 0)
            {
                //otetaan talteen häviäjän vuoronumero
                haviaja = vuoro;
                break;
            }
            //Vaihdetaan vuoro
            vuoro = 1;
            //Kutsutaan toisen pelaajan ottamisfunktiota
            otettu = Pelaaja2Ottaa(papuja);
            //Vähennetään papujen kokonaismäärää otetuilla
            papuja = papuja - otettu;
            Console.WriteLine("{0} otti {1}: jäljellä {2}.", pelaaja2, otettu, papuja);
            //Jäikö käteen viimeinen
            if (papuja == 0)
            {
                //otetaan talteen häviäjän vuoronumero
                haviaja = vuoro;
                break;
            }
            //Vuoro vaihtuu pelaajalle 1
            vuoro = 0;
        }

        //Pelaaja1 hävisi
        if (vuoro == 0)
        {
            Console.WriteLine("{0} hävisi.", pelaaja1);
        }
        //Pelaaja 2 hävisi
        else
        {
            Console.WriteLine("{0} hävisi.", pelaaja2);
        }

        Console.ReadLine();
    }

    //ToDo: funktio pelaajalle1 papujen ottamiseen

    static int Pelaaja1Ottaa(int papuja)
    {
        int removed;

        
        bool guessedCorrect = false;
        while (guessedCorrect == false)
        {
            Console.WriteLine("Ottaa papua");  // Pyyntö pelaajalle 1 ottaa papuja
            removed = Convert.ToInt32(Console.ReadLine()); // Lue otettavien papujen määrä

            // Tarkista, onko syöte kelvollinen
            if (removed > 0 && removed <= 3 && removed <= papuja)
            {
                return removed;
            }
            else 
            { 
                Console.WriteLine("Väärin määrä");
                guessedCorrect = false;  // Merkitse syöte virheelliseksi
            }
        }
        return -1000;

    }
    //ToDo: funktio pelaajalle2 papujen ottamiseen
    static int Pelaaja2Ottaa(int papuja) {
        Random rnd = new Random();
        int randy = rnd.Next(1, 4);  // Generoi satunnainen luku välillä 1-3

        return randy;  // Palauta satunnaisesti valittu otettujen papujen määrä pelaajalta 2
    }
    
}

