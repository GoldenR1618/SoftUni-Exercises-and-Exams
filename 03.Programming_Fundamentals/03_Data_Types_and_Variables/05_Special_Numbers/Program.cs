using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int sum = 0;
                while (num > 10)
                {
                    int num1 = num % 10;
                    sum += num1;
                    num = num / 10;
                }
                sum += num;
                if (sum == 5 || sum == 7 || sum == 11) Console.WriteLine("{0} -> True", i);
                else Console.WriteLine("{0} -> False", i);
            }
        }
    }
}
