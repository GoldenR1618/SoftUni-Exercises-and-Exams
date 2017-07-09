using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5___Брадва__3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = n * 5;
            int left = n * 3;
            int center = 0;
            int right = width - left - center - 2;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', left), new string('-', center), new string('-', right));
                center++;
                right--;
            }

            center--;
            right++;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', left), new string('-', center), new string('-', right));
            }

            for (int i = 1; i <= n/2-1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', left), new string('-', center), new string('-', right));
                left--;
                center++;
                center++;
                right--;
            }

            Console.WriteLine("{0}*{1}*{2}", new string('-', left), new string('*', center), new string('-', right));
        }
    }
}
