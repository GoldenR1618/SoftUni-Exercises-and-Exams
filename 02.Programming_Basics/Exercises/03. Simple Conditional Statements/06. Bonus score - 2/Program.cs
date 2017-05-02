using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus_score___2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var num = int.Parse(Console.ReadLine());
            var bs = 0.0;

            if (num % 10 == 5)
            {
                bs = bs + 2; 
            }

            if (num % 2 == 0)
            {
                bs = bs + 1;
            }
            if (num <= 100)
            {
                bs = bs + 5;
            }
            else if (num > 100 && num <= 1000)
            {
                bs = bs + num*0.2;
            }
            else if (num > 1000)
            {
                bs = bs + num * 0.1;
            }

            Console.WriteLine("Bonus score: " + bs);
            Console.WriteLine("Total score: " + (num+bs));
        }
    }
}
