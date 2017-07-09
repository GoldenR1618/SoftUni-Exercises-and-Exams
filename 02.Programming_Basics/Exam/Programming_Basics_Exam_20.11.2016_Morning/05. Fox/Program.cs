using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 3;
            int left = 1;
            int center = width - 4;
            int right = 1;

            for (int i = 1; i <= n; i++)                                                                                        //Връх.
            {
                Console.WriteLine("{0}\\{1}/{2}", new string('*', left), new string('-', center), new string('*', right));
                left++; center -= 2; right++;
            }

            left = n / 2;
            right = n / 2;
            center = width - left - right - 4;

            for (int i = 1; i <= n / 3; i++)                                                                                    //Средна част. 
            {
                Console.WriteLine("|{0}\\{1}/{2}|", new string('*', left), new string('*', center), new string('*', right));
                left++; center -= 2; right++;
            }

            left = 1;
            center = width - 4;
            right = 1;

            for (int i = 1; i <= n; i++)                                                                                        //Долна част.
            {
                Console.WriteLine("{0}\\{1}/{2}", new string('-', left), new string('*', center), new string('-', right));
                left++; center -= 2; right++;
            }
        }
    }
}
