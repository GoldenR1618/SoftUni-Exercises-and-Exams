using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("$");
                for (int r = 1; r <= i-1; r++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
