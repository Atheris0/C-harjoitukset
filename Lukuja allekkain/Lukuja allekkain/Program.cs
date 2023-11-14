using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lukuja_allekkain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mihin asti tulostetaan?");
            int raja = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (i <= raja)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();
        }
    }
}
