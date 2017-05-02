using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            bool specialNumberCheck = false;

            for (int i = 1; i <= n; i++)
            {
                number = i;

                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }

                specialNumberCheck = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{number} -> {specialNumberCheck}");
                sum = 0;
                i = number;
            }
        }
    }
}
