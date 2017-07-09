using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5___Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('-', n * 3));
                Console.Write("*");
                Console.Write(new string('-', row - 1));
                Console.Write("*");
                Console.Write(new string('-', (n * 5) - 2 - (n * 3) - row + 1));
                Console.WriteLine();
            }
            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string('*', n * 3));
                Console.Write("*");
                Console.Write(new string('-', n - 1));
                Console.Write("*");
                Console.Write(new string('-', n - 1));
                Console.WriteLine();
            }
            for (int row = 1; row <= n / 2 - 1; row++)
            {
                Console.Write(new string('-', n * 3 - row + 1));
                Console.Write("*");
                Console.Write(new string('-', n - 1 + (row-1)*2));
                Console.Write("*");
                Console.Write(new string('-', n - 1 - row+1));
                Console.WriteLine();
            }
            Console.Write(new string('-', n * 3 - n / 2 + 1));
            Console.Write("*");
            Console.Write(new string('*', 5 * n - (n * 3 - n / 2 + 1) - 2 - (n + 1) / 2));
            Console.Write("*");
            Console.Write(new string('-', (n+1)/2));
            Console.WriteLine();
        }
    }
}
