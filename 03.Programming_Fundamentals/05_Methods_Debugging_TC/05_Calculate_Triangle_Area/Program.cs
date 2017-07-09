using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }

        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetTriangleArea(width, height));
        }
    }
}
