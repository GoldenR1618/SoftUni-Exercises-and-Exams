using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dashes = (n - 1) / 2;
            int center = 0;
            int stars = 1;

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                if (n % 2 == 0) { stars++; }                                                                                //Първи ред.
                Console.Write("{0}{1}{2}", new string('-', dashes), new string('*', stars), new string('-', dashes));
                Console.WriteLine();

                if (n % 2 == 0) { center += 2; dashes--; } else { center++; dashes--; }                                     //Горна част.
                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.Write("{0}*{1}*{2}", new string('-', dashes), new string('-', center), new string('-', dashes));
                    Console.WriteLine();
                    dashes--; center += 2;
                }

                if (n % 2 == 0)                                                                                             //Долна част.
                {
                    center -= 4; dashes += 2;
                    for (int i = 1; i <= (n - 1) / 2; i++)
                    {
                        Console.Write("{0}*{1}*{2}", new string('-', dashes), new string('-', center), new string('-', dashes));
                        Console.WriteLine();
                        dashes++; center -= 2;
                    }
                }
                else
                {
                    dashes += 2; center -= 4;
                    for (int i = 1; i <= (n - 1) / 2 - 1; i++)
                    {
                        Console.Write("{0}*{1}*{2}", new string('-', dashes), new string('-', center), new string('-', dashes));
                        Console.WriteLine();
                        dashes++; center -= 2;
                    }

                    Console.Write("{0}{1}{2}", new string('-', dashes), new string('*', stars), new string('-', dashes));   //Последен ред.
                    Console.WriteLine();
                }
            }
        }
    }
}
