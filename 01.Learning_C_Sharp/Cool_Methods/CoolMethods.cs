namespace Cool_Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class CoolMethods
    {
        public static void Main(string[] args)
        {

        }

        //Arr - Splits the array after the given E.g. [1, 2, 3, 4, 5] -> exchange 2 -> result: [4, 5, 1, 2, 3]
        public static int[] Exchange(int[] arr, int index)
        {
            return arr.Skip(index).Concat(arr.Take(index)).ToArray();       //Пропусни index на брой числа, към останалите залепи index на брой числа.
        }

        //Arr - Returns the INDEX of the max even/odd element -> [1, 4, 8, 2, 3] -> max odd -> print 4--------
        public static string IndexMaxMinEvenOdd(int[] arr, string maxMin, string evenOdd)
        {
            int remainder = evenOdd == "odd" ? 1 : 0;       //Дефинирам остатъка - 0 при четни, 1 при нечетни
            int[] filteredArr = arr.Where(n => n % 2 == remainder).ToArray();   //Тук са вече всички четни или всички нечетни числа

            if (!filteredArr.Any()) //Имали съвпадения?
            {
                return "No matches";
            }

            return maxMin == "min" ? Array.LastIndexOf(arr, filteredArr.Min()).ToString() : Array.LastIndexOf(arr, filteredArr.Max()).ToString();
        }

        //Arr - Returns the first/last {count} even/odd elements -> [1, 8, 2, 3] -> last 2 odd -> print [1, 3]---
        public static string FirstLastCountEvenOdd(int[] arr, string firstLast, int count, string oddEven)
        {
            if (count > arr.Length)     //Броя елементи не може да е по-голям от броя на ел. в масива.
            {
                return "Invalid count";
            }

            int remainder = oddEven == "odd" ? 1 : 0;       //Дефинирам остатъка - 0 при четни, 1 при нечетни
            int[] filteredArr = arr.Where(n => n % 2 == remainder).ToArray();   //Тук са вече всички четни или всички нечетни числа

            return firstLast == "first" ? $"[{string.Join(", ", filteredArr.Take(count))}]" : $"[{string.Join(", ", filteredArr.Reverse().Take(count).Reverse())}]";
        }

        //Arr - Reverse from [start] count [count] - reverse a portion of the array – just [count] elements starting at index [start];
        public static void Reverce(List<string> list, int startR, int countR)
        {
            List<string> reverce = new List<string>();

            for (int i = startR + countR - 1; i >= startR; i--)
            {
                reverce.Add(list[i]);
            }

            for (int r = startR, j = 0; r < startR + countR; r++, j++)
            {
                list[r] = reverce[j];
            }
        }

        //Arr - sort from [start] count [count] – sort a portion of the array – just [count] elements starting at index [start];
        public static void Sort(List<string> list, int startS, int countS)
        {
            List<string> sorted = new List<string>();

            for (int i = startS; i < startS + countS; i++)
            {
                sorted.Add(list[i]);
            }

            sorted.Sort();

            for (int r = startS, j = 0; r < startS + countS; r++, j++)
            {
                list[r] = sorted[j];
            }
        }

        //Arr - rollLeft [count] times – move all elements in the array to the left [count] times. On each roll, the first element is placed at the end of the array
        public static void RollLeft(List<string> list, int countRL)
        {
            string[] rollL = new string[list.Count];

            int newCount = countRL % rollL.Length;

            for (int i = 0; i < list.Count; i++)
            {
                if (i - newCount >= 0)
                {
                    rollL[i - newCount] = list[i];
                }
                else
                {
                    rollL[i + (rollL.Length - newCount)] = list[i];
                }
            }

            for (int j = 0; j < list.Count; j++)
            {
                list[j] = rollL[j];
            }
        }

        //Arr - rollRight [count] times – move all elements in the array to the right [count] times. On each roll, the last element is placed at the beginning of the array
        public static void RollRight(List<string> list, int countRR)
        {
            string[] rollR = new string[list.Count];

            int newCount = countRR % rollR.Length;

            for (int i = 0; i < list.Count; i++)
            {
                if (i + newCount < rollR.Length)
                {
                    rollR[i + newCount] = list[i];
                }
                else
                {
                    rollR[i - (rollR.Length - newCount)] = list[i];
                }
            }

            for (int j = 0; j < list.Count; j++)
            {
                list[j] = rollR[j];
            }
        }

        //Reverce string
        public static string Reverce(string forrev)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = forrev.Length - 1; i >= 0; i--)
            {
                sb.Append(forrev[i]);
            }

            return sb.ToString();
        }

        //Raise to power
        public static double RaiseToPower(double number, int power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

        //Get sum of Even digits
        public static int GetSumOfEvenDigits(int n)
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

        //Get sum of Odd digits
        public static int GetSumOfOddDigits(int n)
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

        //Holidays Between Two Dates
        public static int HolidaysBetweenTwoDates(DateTime startDate, DateTime endDate)
        {
            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            return holidaysCount;
        }

        //Calculate Fibonacci number
        public static int FibonacciNumber(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }

            int oldSum = 1;
            int newSum = 1;
            int fibNum = 0;

            for (int i = 2; i <= n; i++)
            {
                fibNum = oldSum + newSum;
                oldSum = newSum;
                newSum = fibNum;
            }

            return fibNum;
        }

        //Prime checker
        public static bool PrimeChecker(long n)
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

        //Find prime number in given range
        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();

            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (PrimeChecker(currentNum))
                {
                    primes.Add(currentNum); //Добавя числото към листа.
                }
            }

            return primes;
        }

        //Find point that is closest to the center
        public static bool FindClosestPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt((Math.Abs(x1) * Math.Abs(x1)) + (Math.Abs(y1) * Math.Abs(y1))) <= Math.Sqrt((Math.Abs(x2) * Math.Abs(x2)) + (Math.Abs(y2) * Math.Abs(y2))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Find longer line from two lines
        public static bool LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (Math.Sqrt((Math.Abs(x1 - x2) * Math.Abs(x1 - x2)) + (Math.Abs(y1 - y2) * Math.Abs(y1 - y2))) >= Math.Sqrt((Math.Abs(x3 - x4) * Math.Abs(x3 - x4)) + (Math.Abs(y3 - y4) * Math.Abs(y3 - y4))))
            {
                return true; //if first line is longer from second line.
            }

            return false;
        }

        //Palindrome checker
        public static bool PalindromeChecker(int num)
        {
            string stringNum = num.ToString();

            for (int i = 0; i < stringNum.Length; i++)
            {
                if (stringNum[i] != stringNum[stringNum.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        //Factorial calculator
        public static BigInteger FactorialCalculator(uint n)
        {
            BigInteger factorial = 1;

            for (uint i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
