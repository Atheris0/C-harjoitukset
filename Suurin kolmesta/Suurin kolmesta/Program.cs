using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhteenlasku_funktio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SuurinKolmesta(17,8,9));
            Console.ReadLine();

        }
        static int SuurinKolmesta(int luku1, int luku2, int luku3)
        {
            int result;
            if (luku1 >= luku2 && luku1 >= luku3) { result = luku1; } 
            else if (luku2 >= luku1 && luku2 >= luku3) {  result = luku2; } 
            else 
            {
                result = luku3;
            }
            return result;
        }
    }
}
