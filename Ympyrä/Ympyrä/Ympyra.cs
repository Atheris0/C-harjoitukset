using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ympyrä
{
    internal class Ympyra
    {
        public int x;
        public int y;
        public int r;
        public Ympyra(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        public int keskipisteX { get { return x; } set { x = value; } }
        public int keskipisteY { get { return y; } set { y = value; } }

        public int sade { get { return r; } set { r = value; } }

        public double PintaAla()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
