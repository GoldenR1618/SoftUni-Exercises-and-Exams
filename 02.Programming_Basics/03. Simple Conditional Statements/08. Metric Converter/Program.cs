using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = double.Parse(Console.ReadLine());
            var src = Console.ReadLine().ToLower();
            var dest = Console.ReadLine().ToLower();

            if (src == "mm")
            {
                size = size / 1000;
            }
            else if (src == "cm")
            {
                size = size / 100;
            }
            else if (src == "m")
            {
                size = size / 1;
            }
            else if (src == "km")
            {
                size = size / 0.001;
            }
            else if (src == "in")
            {
                size = size / 39.3700787;
            }
            else if (src == "mi")
            {
                size = size / 0.000621371192;
            }
            else if (src == "ft")
            {
                size = size / 3.2808399;
            }
            else if (src == "yd")
            {
                size = size / 1.0936133;
            }


            if (dest == "mm")
            {
                size = size * 1000;
            }
            else if (dest == "cm")
            {
                size = size * 100;
            }
            else if (dest == "m")
            {
                size = size * 1;
            }
            else if (dest == "km")
            {
                size = size * 0.001;
            }
            else if (dest == "in")
            {
                size = size * 39.3700787;
            }
            else if (dest == "mi")
            {
                size = size * 0.000621371192;
            }
            else if (dest == "ft")
            {
                size = size * 3.2808399;
            }
            else if (dest == "yd")
            {
                size = size * 1.0936133;
            }

            Console.WriteLine(size + " " + dest);
        }
    }
}
