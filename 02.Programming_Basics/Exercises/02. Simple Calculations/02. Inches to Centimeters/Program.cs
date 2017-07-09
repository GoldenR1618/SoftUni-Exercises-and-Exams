using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter inches:");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Converted to centimeters = ");
            Console.WriteLine(n * 2.54);
        }
    }
}
