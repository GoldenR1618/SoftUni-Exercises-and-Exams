using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());

            double width = Math.Max(x1, x2) - Math.Min(x1, x2);
            double height = Math.Max(y1, y2) - Math.Min(y1, y2);

            var area = width * height;
            var perimeter = 2 * (width + height);
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}
