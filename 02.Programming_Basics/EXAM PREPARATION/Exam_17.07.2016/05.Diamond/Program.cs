using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int ширина = n * 5;
            int височина = n * 3 + 2;

            int ляво = n;
            int среда = ширина - 2 * n - 2;
            int дясно = n;

            Console.WriteLine("{0}*{1}*{2}", new string('.', ляво), new string('*', среда), new string('.', дясно));
            for (int i = 1; i <= n-1; i++)
            {
                ляво--; среда+=2;  дясно--;
                Console.WriteLine("{0}*{1}*{2}", new string('.', ляво), new string('.', среда), new string('.', дясно));
            }
            Console.WriteLine(new string('*', ширина));
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('.', ляво), new string('.', среда), new string('.', дясно));
                ляво++; среда -= 2; дясно++;
            }
            Console.WriteLine("{0}*{1}*{2}", new string('.', ляво), new string('*', среда), new string('.', дясно));
        }
    }
}
