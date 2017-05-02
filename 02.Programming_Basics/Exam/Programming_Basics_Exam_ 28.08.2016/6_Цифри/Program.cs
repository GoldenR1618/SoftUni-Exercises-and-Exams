using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6___Цифри
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = n / 100;
            int num2 = (n / 10) % 10;
            int num3 = n % 10;
            int row = num1 + num2;
            int col = num1 + num3;

            for (int i = 1; i <= row; i++)
            {
                for (int r = 1; r <= col; r++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - num1;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - num2;
                    }
                    else
                    {
                        n = n + num3;
                    }
                        Console.Write("{0} ", n);
                }
                Console.WriteLine();
            }
        }
    }
}
