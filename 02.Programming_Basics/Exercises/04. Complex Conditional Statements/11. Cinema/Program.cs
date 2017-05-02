using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var tip = Console.ReadLine().ToLower();
            var redove = int.Parse(Console.ReadLine());
            var koloni = int.Parse(Console.ReadLine());

            switch (tip)
            {
                case "premiere": Console.WriteLine("{0:f2} leva", redove * koloni * 12.00); break;
                case "normal": Console.WriteLine("{0:f2} leva", redove * koloni * 7.50); break;
                case "discount": Console.WriteLine("{0:f2} leva", redove * koloni * 5.00); break;
                default: Console.WriteLine("Error!"); break;
            }
        }
    }
}
