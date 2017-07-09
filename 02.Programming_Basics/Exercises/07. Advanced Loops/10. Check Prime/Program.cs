using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool prime = true;

            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i <= n - 1; i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                        break;                      //break терминира цикъла.
                    }
                }
                if (prime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
        }
    }
}
