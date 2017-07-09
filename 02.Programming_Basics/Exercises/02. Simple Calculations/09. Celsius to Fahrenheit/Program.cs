using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Celsius = ");
            double c = double.Parse(Console.ReadLine());
            double t = c*1.8 + 32;
            Console.WriteLine("Fahrenheit = {0}", t);
        }
    }
}
