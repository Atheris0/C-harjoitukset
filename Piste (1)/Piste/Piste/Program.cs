using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piste
{
    class PointTest
    {
        static void Main(string[] args)
        {
            /*Point startingPoint = new Point(3, 4);
            Console.WriteLine(startingPoint.X + ", " + startingPoint.Y);
            startingPoint.X = 6;
            startingPoint.Y = 9;
            Console.WriteLine(startingPoint.X + ", " + startingPoint.Y);*/

            Point pointA = new Point(3, 4);
            Console.WriteLine(pointA.X + ", " + pointA.Y);
            pointA.X = 6;
            pointA.Y = 9;
            Console.WriteLine(pointA);

            Console.ReadLine();
        }
    }
}
