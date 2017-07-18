using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fibonacci_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));
        }

        static int Fib(int n)
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
    }
}
