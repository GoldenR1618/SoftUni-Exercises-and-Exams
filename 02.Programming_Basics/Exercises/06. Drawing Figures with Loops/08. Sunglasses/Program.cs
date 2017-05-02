using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

                Console.Write(new string('*', n*2));                    //Горна линия.
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', n * 2));

                for (int row = 1; row <= n-2; row++)
                {
                    if (row == ((n-1)/2))
                    {
                        Console.Write("*");
                        Console.Write(new string('/', n + (n-2)));
                        Console.Write("*");
                        Console.Write(new string('|', n));
                        Console.Write("*");
                        Console.Write(new string('/', n + (n - 2)));
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.Write("*");
                        Console.Write(new string('/', n + (n - 2)));
                        Console.Write("*");
                        Console.Write(new string(' ', n));
                        Console.Write("*");
                        Console.Write(new string('/', n + (n - 2)));
                        Console.WriteLine("*");
                    }
                }
                  
                Console.Write(new string('*', n * 2));                    //Долна линия.
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', n * 2));
        }
    }
}
