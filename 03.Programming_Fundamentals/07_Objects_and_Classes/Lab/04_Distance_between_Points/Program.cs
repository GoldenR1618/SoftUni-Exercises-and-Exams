using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Distance_between_Points
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] inputOne = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Point first = new Point
            {
                X = inputOne[0],
                Y = inputOne[1]
            };

            double[] inputTwo = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Point second = new Point
            {
                X = inputTwo[0],
                Y = inputTwo[1]
            };

            Console.WriteLine("{0:F3}", CalculateDistance(first, second));
        }

        private static double CalculateDistance(Point first, Point second)
        {
            return Math.Sqrt((first.X-second.X) * (first.X - second.X) + (first.Y - second.Y) * (first.Y - second.Y));
        }
    }
}
