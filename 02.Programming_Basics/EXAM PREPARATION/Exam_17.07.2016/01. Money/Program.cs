using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yoan = double.Parse(Console.ReadLine());
            double komisionna = double.Parse(Console.ReadLine());
            double evra = (bitcoin * 1168 / 1.95 + yoan * 0.15 * 1.76 / 1.95) * ((100 - komisionna) / 100);

            Console.WriteLine(evra);
        }
    }
}
