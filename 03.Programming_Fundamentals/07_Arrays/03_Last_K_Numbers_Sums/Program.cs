using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] seq = new long[n];
            seq[0] = 1;

            for (int index = 1; index < seq.Length; index++)
            {
                for (int r = index-1; r >= index-k; r--)
                {
                    if (r < 0)
                    {
                        break;
                    }
                    seq[index] = seq[index] + seq[r];
                }
            }

            for (int i = 0; i < seq.Length; i++)
            {
                Console.Write($"{seq[i]} ");
            }
            Console.WriteLine();
        }
    }
}
