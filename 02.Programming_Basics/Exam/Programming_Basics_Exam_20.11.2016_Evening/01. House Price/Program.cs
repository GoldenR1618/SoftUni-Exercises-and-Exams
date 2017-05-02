using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double room1 = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double squareMeter = double.Parse(Console.ReadLine());

            double apartament = ((kitchen + (room1 / 2) + room1 + (room1 * 1.1) + (room1 * 1.1) * 1.1) * 1.05) * squareMeter;
            Console.WriteLine("{0:f2}", apartament);
        }
    }
}
