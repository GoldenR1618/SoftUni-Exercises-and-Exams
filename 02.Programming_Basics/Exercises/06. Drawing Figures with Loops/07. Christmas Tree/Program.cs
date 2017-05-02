using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 100)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                for (int i = 1; i <= n+1; i++)                          //Връхче.
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");

                for (int row = 1; row <= n; row++)                      //Чертаене на редовете.
                {
                    for (int space = n-row; space > 0; space--)
                    {
                        Console.Write(" ");
                    }

                    for (int stars = 1; stars <= row; stars++)
                    {
                        Console.Write("*");
                    }

                    Console.Write(" | ");

                    for (int stars = 1; stars <= row; stars++)
                    {
                       Console.Write("*");
                    }

                        Console.WriteLine();
                }
            }
        }
    }
}
