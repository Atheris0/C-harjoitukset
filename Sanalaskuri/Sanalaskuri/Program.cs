using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanalaskuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rivi;
            List<string> list = new List<string>();
            
            using (StreamReader file = new StreamReader("sanoja.txt"))
            {
                while ((rivi = file.ReadLine()) != null)
                {
                    string[] sanalista = rivi.Split(new char[] { ' ' });
                    
                    foreach (string item in sanalista)
                    {
                        //lisätään sanat listalle
                        list.Add(item);
                    }
                }
            }
            using (StreamWriter toinenfile = new StreamWriter("esimerkki.txt"))
            {
                //sanat aakkosjärjestyksessä
                list.Sort();
                foreach (var item in list)
                {
                    //kirjoitetaan järjestetty sanat
                    toinenfile.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
