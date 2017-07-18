using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                  //Подкана за валидно число.

            while (n < 1 || n > 12)                         
            {
                Console.WriteLine("Невалидно число!");
                n = int.Parse(Console.ReadLine());
            }
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}
