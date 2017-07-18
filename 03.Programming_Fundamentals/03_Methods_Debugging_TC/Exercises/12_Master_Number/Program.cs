using System;
using System.Linq;


namespace _12_Master_Number
{
    class Program
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (Palindrome(i) && SumDigitsDivisibleSeven(i) && EvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool EvenDigit(int i)
        {
            while (i > 0)
            {
                int checkEvenDigits = i % 10;

                if (checkEvenDigits % 2 == 0)
                {
                    return true;
                }

                i = i / 10;
            }

            return false;
        }

        private static bool SumDigitsDivisibleSeven(int i)
        {
            int sumOfDigits = 0;

            while (i > 0)
            {
               sumOfDigits += i % 10;
                i = i / 10;
            }

            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool Palindrome(int i)
        {
            string stringNum = i.ToString();
            for (int r = 0; r < stringNum.Length; r++)
            {
                if (stringNum[r] != stringNum[stringNum.Length - 1 - r])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
