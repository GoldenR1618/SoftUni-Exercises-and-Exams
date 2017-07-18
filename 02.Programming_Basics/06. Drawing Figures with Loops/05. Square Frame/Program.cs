using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.Write("+");                         //Първи ред.
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            for (int i = 1; i <= n-2; i++)            //Средни редове.
            {
                Console.Write("|");
                for (int r = 1; r <= n-2; r++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            Console.Write("+");                         //Последен ред.
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
