using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int comb = int.Parse(Console.ReadLine());

            for (int i = start; i <= stop; i++)
            {
                for (int r = start; r <= stop; r++)
                {
                    if (comb == 0)
                    {
                        break;
                    }
                    Console.Write("<{0}-{1}>", i, r);
                    comb--;
                }
            }
        }
    }
}
