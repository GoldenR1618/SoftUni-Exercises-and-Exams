using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char stop = char.Parse(Console.ReadLine());
            char wo = char.Parse(Console.ReadLine());

            int broi = 0;

            for (char i = start; i <= stop; i++)
            {
                for (char r = start; r <= stop; r++)
                {
                    for (char j = start; j <= stop; j++)
                    {
                        if (wo != i && wo != r && wo != j)
                        {
                            Console.Write("{0}{1}{2} ", i, r, j);
                            broi++;
                        }
                    }
                }
            }
            Console.WriteLine(broi);
        }
    }
}
