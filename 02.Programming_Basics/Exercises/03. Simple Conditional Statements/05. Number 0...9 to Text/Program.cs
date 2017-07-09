using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Number_0._._._9_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("one");
            }
            else if (num == 2)
            {
                Console.WriteLine("two");
            }
            else if (num == 3)
            {
                Console.WriteLine("three");
            }
            else if (num == 4)
            {
                Console.WriteLine("four");
            }
            else if (num == 5)
            {
                Console.WriteLine("five");
            }
            else if (num == 6)
            {
                Console.WriteLine("six");
            }
            else if (num == 7)
            {
                Console.WriteLine("seven");
            }
            else if (num == 8)
            {
                Console.WriteLine("eight");
            }
            else if (num == 9)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
