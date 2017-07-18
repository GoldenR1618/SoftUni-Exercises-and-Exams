using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int row = 1; row <= n / 2; row++)                          //n определя x кординатат, a row - y координатата във фигурата.
                {
                    Console.Write(new string ('-', n / 2 - row));
                    Console.Write("*");
                    Console.Write(new string('-', (row-1)*2));
                    Console.Write("*");
                    Console.WriteLine(new string('-', n / 2 - row));
                    
                }

                for (int row = 1; row <= (n / 2) - 1; row++)
                {
                    Console.Write(new string('-', row));
                    Console.Write("*");
                    Console.Write(new string('-', (n - 2) -2 * row));
                    Console.Write("*");
                    Console.WriteLine(new string('-', row));
                }
            }
            else
            {
                if (n == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write(new string('-', (n + 1) / 2 - 1));
                    Console.Write("*");
                    Console.WriteLine(new string('-', (n + 1) / 2 - 1));

                    for (int row = 1; row < (n + 1) / 2; row++)                          //n определя x кординатат, a row - y координатата във фигурата.
                    {
                        Console.Write(new string('-', (n + 1) / 2 - row - 1));
                        Console.Write("*");
                        Console.Write(new string('-', row * 2 - 1));
                        Console.Write("*");
                        Console.Write(new string('-', (n + 1) / 2 - row - 1));
                        Console.WriteLine();
                    }

                    for (int row = 1; row <= ((n - 1) / 2 - 1); row++)
                    {
                        Console.Write(new string('-', row));
                        Console.Write("*");
                        Console.Write(new string('-', n - 2 * row - 2));
                        Console.Write("*");
                        Console.WriteLine(new string('-', row));
                    }

                    Console.Write(new string('-', (n + 1) / 2 - 1));
                    Console.Write("*");
                    Console.WriteLine(new string('-', (n + 1) / 2 - 1));

                }
            }
        }
    }
}
