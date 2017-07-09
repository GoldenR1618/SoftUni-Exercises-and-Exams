using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = int.Parse(Console.ReadLine());
            var t2 = int.Parse(Console.ReadLine());
            var t3 = int.Parse(Console.ReadLine());
            var sum = t1 + t2 + t3;
            var min = 0;
            if (sum < 59)
            {
                min = 0;
            }
            else if (sum > 59 && sum < 120)
            {
                min = 1;
            }
            else if (sum >= 120 && sum < 179)
            {
                min = 2;
            }
            var sec = sum - min * 60;
            Console.Write(min);
            Console.Write(":");
            if (sec < 10)
            {
                Console.Write("0");
            }
            Console.WriteLine(sec);
        }
    }
}
