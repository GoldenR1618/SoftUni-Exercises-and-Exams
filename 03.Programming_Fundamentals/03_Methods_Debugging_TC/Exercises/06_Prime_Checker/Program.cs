using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Prime_Checker
{
    class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(n);

            Console.WriteLine(isPrime);
        }

        public static bool IsPrime(long n)
        {
            bool isPrime = true;

            if (n == 0 || n == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {       
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
