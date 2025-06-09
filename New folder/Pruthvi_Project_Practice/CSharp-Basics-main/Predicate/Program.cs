using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points =
            {
                new Point(8,5),
                new Point(10,4),
                new Point(9,9),
                new Point(6,5),
                new Point(5,2),
                new Point(10,9),
            };

            Predicate<Point> predicate = FindPoints;
            Point first = Array.Find(points, predicate);

            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);
            Console.ReadKey();
        }
        private static bool FindPoints(Point obj)
        {
            return obj.X * obj.Y > 80;
        }
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
   
}
