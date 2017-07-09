using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double num1 = float.Parse(Console.ReadLine());
            double num2 = float.Parse(Console.ReadLine());
            double sum1 = num1 + num2;
            double diff = 0;

            while ((n-1) > 0)
            {
                double num3 = float.Parse(Console.ReadLine());
                double num4 = float.Parse(Console.ReadLine());
                double sum2 = num3 + num4;
                diff = Math.Abs(sum1 - sum2);
                sum1 = sum2;
                n--;
            }

            if (diff == 0)
            {
                Console.WriteLine("Yes, value=" + sum1);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + diff);
            }
        }
    }
}
