using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double kursDolar = double.Parse(Console.ReadLine());
            double profitDolara = (((n * m * 12 + n * m * 2.5) * 0.75) / 365);

            Console.WriteLine("{0:f2}", profitDolara * kursDolar);
        }
    }
}
