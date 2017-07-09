using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int sum = 0;

            while (n >= 1)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num > max)
                {
                    max = num;                    
                }
                n--;
            }
            sum = sum - max;
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(max - sum));
            }
            
        }
    }
}
