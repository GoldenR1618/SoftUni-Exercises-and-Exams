using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 3 * n;
            int left = width / 2 - 1;
            int center = 0;
            int right = width / 2 - 1;

            for (int i = 1; i <= n; i++)        //Връх.
            {
                Console.WriteLine("{0}/{1}\\{2}", new string('.', left), new string(' ', center), new string('.', right));
                left--; center += 2; right--;
            }
            left++; center -= 2; right++;
            Console.WriteLine("{0}*{1}*{2}", new string('.', left), new string('*', center), new string('.', right));
            for (int i = 1; i <= n * 2; i++)   //Средна част. 
            {
                Console.WriteLine("{0}|{1}|{2}", new string('.', left), new string('\\', center), new string('.', right));
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{2}", new string('.', left), new string('*', center), new string('.', right));
                left--; center += 2; right--;
            }
        }
    }
}
