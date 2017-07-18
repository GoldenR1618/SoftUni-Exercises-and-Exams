using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_Stars_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int space = n - 1;

            for (int row = 1; row <= n; row++)                  //Горна част.
            {
                Console.Write(new string(' ', space));
                space--;
                Console.Write("*");
                for (int col = 1; col <= row - 1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            space+=2;        //1

            for (int row = 1; row <= n-1; row++)
            {
                Console.Write(new string(' ', space));
                space++;
                Console.Write("*");
                for (int col = n - row; col > 1; col--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
