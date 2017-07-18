using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_by_Odds
{
    class Program
    {   
        static int GetSumOfEvenDigits(int n)
        {
            int evenSum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                n /= 10;
            }
            return evenSum;
        }

        static int GetSumOfOddDigits(int n)
        {
            int oddSum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }
                n /= 10;
            }
            return oddSum;
        }

        static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }

        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }
    }
}
