using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int broyPok1 = int.Parse(Console.ReadLine());
            int broyPok2 = int.Parse(Console.ReadLine());
            int maksBitki = int.Parse(Console.ReadLine());

            for (int i = 1; i <= broyPok1; i++)
            {
                for (int r = 1; r <= broyPok2; r++)
                {
                    if (maksBitki == 0)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ", i, r);
                    maksBitki--;
                }
            }
        }
    }
}
