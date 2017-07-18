using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 4 * n + 1;
            int high = 2 * n + 5;

            int left = (width - 3) / 2;
            int center = 1;
            int center1 = 0;
            int center2 = 0;
            int right = (width - 3) / 2;


            Console.WriteLine("{0}/{1}\\{2}", new string('.', left), new string('|', center), new string('.', right));
            Console.WriteLine("{0}\\{1}/{2}", new string('.', left), new string('|', center), new string('.', right));



            for (int i = 1; i <= n * 2; i++)                                                                                    //Средна част. 
            {
                Console.WriteLine("{0}*{1}*{2}*{3}", new string('.', left), new string('-', center1), new string('-', center2), new string('.', right));
                left--;
                center1++;
                center2++;
                right--;
            }

            Console.WriteLine(new string('*', width));           //Разделителна линия.
            for (int i = 1; i <= width / 2; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', width));
        }
    }
}
