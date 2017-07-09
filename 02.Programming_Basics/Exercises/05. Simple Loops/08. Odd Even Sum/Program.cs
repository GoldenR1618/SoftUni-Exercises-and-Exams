using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum = evenSum + num;
                }
                else
                {
                    oddSum = oddSum + num;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes Sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No Diff = " + Math.Abs(evenSum - oddSum));
            }
        }
    }
}
