using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14_Factorial_Trailing_Zeroes
{
    class Program
    {
        public static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (uint i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(TrailingZeroes(factorial));
        }

        public static int TrailingZeroes(BigInteger factorial)
        {
            int zeroCounter = 0;

            while (factorial > 0)
            {
                if (factorial % 10 == 0)
                {
                    zeroCounter++;
                }
                else
                {
                    break;
                }

                factorial = factorial / 10;
            }

            return zeroCounter;
        }
    }
}
