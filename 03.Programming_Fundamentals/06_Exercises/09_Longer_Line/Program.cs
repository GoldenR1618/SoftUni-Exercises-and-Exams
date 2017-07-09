using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Longer_Line
{
    class Program
    {
        private static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            var longerLine = LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);

            if (longerLine)
            {
                if (FindClosestPoint(x1, y1, x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (FindClosestPoint(x3, y3, x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        private static bool LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (Math.Sqrt((Math.Abs(x1 - x2) * Math.Abs(x1 - x2)) + (Math.Abs(y1 - y2) * Math.Abs(y1 - y2))) >= Math.Sqrt((Math.Abs(x3 - x4) * Math.Abs(x3 - x4)) + (Math.Abs(y3 - y4) * Math.Abs(y3 - y4))))
            {
                return true; //if first line is longer from second line.
            }

            return false;
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
