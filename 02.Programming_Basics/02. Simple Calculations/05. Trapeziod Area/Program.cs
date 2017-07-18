using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("b1 = ");
            var b1 = double.Parse(Console.ReadLine());

            Console.Write("b2 = ");
            var b2 = double.Parse(Console.ReadLine());

            Console.Write("h = ");
            var h = double.Parse(Console.ReadLine());

            var area = (b1 + b2) * h / 2;
            Console.WriteLine("Trapezoid area = " + area);

        }
    }
}
