using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Center_Point
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            var closestPoint = FindClosestPoint(x1, y1, x2, y2);

            if (closestPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static bool FindClosestPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt((Math.Abs(x1) * Math.Abs(x1)) + (Math.Abs(y1) * Math.Abs(y1))) <= Math.Sqrt((Math.Abs(x2) * Math.Abs(x2)) + (Math.Abs(y2) * Math.Abs(y2))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
