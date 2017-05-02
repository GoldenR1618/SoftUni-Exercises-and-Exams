using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool[] prime = new bool[n + 1];

            for (int k = 0; k <= n; k++)
            {
                prime[k] = true;
            }

            prime[0] = prime[1] = false;

            for (int i = 2; i <= n; i++)
            {
                if (prime[i])
                {
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime[i] = true;

                            int p = 2;

                            while (p * i <= n)
                            {
                                prime[p * i] = false;
                                p++;
                            }

                        }
                    }
                }
            }

            for (int i = 0; i <= n; i++)
            {
                if (prime[i])
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }
    }
}
