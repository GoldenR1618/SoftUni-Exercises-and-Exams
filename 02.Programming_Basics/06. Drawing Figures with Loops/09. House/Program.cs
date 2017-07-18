using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)     //Четно.
            {
                for (int row = 1; row <= n/2; row++)    //Покривче.
                {
                    Console.Write(new string('-', (n / 2) - row));
                    Console.Write(new string('*', row * 2));
                    Console.WriteLine(new string('-', (n / 2) - row));
                }

                for (int row = 1; row <= n/2; row++)    //Етажче.
                {
                    Console.Write("|");
                    Console.Write(new string('*', n-2));
                    Console.WriteLine("|");
                }
            }
            else            //Нечетно.
            {
                for (int row = 1; row <= (n+1)/2; row++)    //Покривче.
                {
                    Console.Write(new string('-', ((n + 1) / 2 - row)));
                    Console.Write(new string('*', row + row - 1));
                    Console.WriteLine(new string('-', ((n + 1) / 2 - row)));
                }

                for (int row = 1; row <= (n-1)/2; row++)     //Етажче.
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }
            }
        }
    }
}
