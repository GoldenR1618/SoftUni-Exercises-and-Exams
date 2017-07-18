using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    sum = sum + 1;
                }
                else if (s[i] == 'e')
                {
                    sum = sum + 2;
                }
                else if (s[i] == 'i')
                {
                    sum = sum + 3;
                }
                else if (s[i] == 'o')
                {
                    sum = sum + 4;
                }
                else if (s[i] == 'u')
                {
                    sum = sum + 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
