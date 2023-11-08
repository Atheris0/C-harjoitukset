using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolikonheitto
{
    public class Kolikko
    {
        private int[] throws;
        private int headsCount = 0;
        private int tailsCount = 0;

        public Kolikko(int[] throws)
        {
           this.throws = throws;
        }
        
        public void SuperCounter()
        {
            for(int i = 0; i < throws.Length; i++)
            {
                if (throws[i] == 1)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }
            }
        }

        public string Stats()
        {
            return $"Kolikkoa heitetty {throws.Length} kertaa.\nKlaavoja tullut {tailsCount}\nKruunia tullut {headsCount}";
        }
    }
}
