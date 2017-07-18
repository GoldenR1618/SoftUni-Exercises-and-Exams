using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, input square site 'a'");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Square = ");
            Console.WriteLine(a*a);
        }
    }
}
