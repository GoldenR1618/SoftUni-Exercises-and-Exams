using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_English_Name_of_Last_Digit
{
    class Program
    {
        static void Main()
        {
            long n = Math.Abs(long.Parse(Console.ReadLine()));

            Console.WriteLine(EnglishName(n));
        }

        static string EnglishName(long n)
        {
            while (n > 9)
            {
                n = n % 10;
            }

            string name = "";

            switch (n)
            {
                case 1: name = "one"; break;
                case 2: name = "two"; break;
                case 3: name = "tree"; break;
                case 4: name = "four"; break;
                case 5: name = "five"; break;
                case 6: name = "six"; break;
                case 7: name = "seven"; break;
                case 8: name = "eight"; break;
                case 9: name = "nine"; break;
                case 0: name = "zero"; break;
                default:
                    break;
            }

            return name;
        }
    }
}
