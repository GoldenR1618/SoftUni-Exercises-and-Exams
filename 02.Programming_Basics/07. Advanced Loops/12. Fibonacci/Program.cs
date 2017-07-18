using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("1");
            }
            else
            {
                int nMinus1 = 1;
                int nMinus2 = 1;
                int fibonacci = 0;

                for (int i = 2; i <= n; i++)
                {
                    fibonacci = nMinus1 + nMinus2;
                    nMinus2 = nMinus1;
                    nMinus1 = fibonacci;
                }
                Console.WriteLine(fibonacci);
            }
        }
    }
}
