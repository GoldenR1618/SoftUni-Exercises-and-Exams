using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)                    //Горна половина.
            {
                for (int space = n-row; space > 0; space--)
                {
                    Console.Write(" ");
                }

                for (int stars = 1; stars <= row; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int row = 1; row <= n-1; row++)                    //Долна половина.
            {
                for (int space = 1; space <= row; space++)
                {
                    Console.Write(" ");
                }

                for (int stars = n-row; stars > 0; stars--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }                                                 
        }
    }
}

/* 
Проверка на алгоритъма при n=3:
 
n=3

row 1 - 3 ++

1 space 2 - 1 --  stars 1 - 1 ++  _,_,*,
2 space 1 - 1 --  stars 1 - 2 ++  _,*,*,
3 space 0 - 1 --  stars 1 - 3 ++  *,*,*,

row 1 - 2 ++

1 space 1 - 1 ++ stars 2 - 1 --  _,*,*,
2 space 1 - 2 ++ stars 1 - 1 --  _,_,*,

 */