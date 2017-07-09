using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int stopChar = int.Parse(Console.ReadLine());

            for (int i = startChar; i <= stopChar; i++)
            {
                Console.Write("{0} ", Convert.ToChar(i));
            }
            Console.WriteLine();
        }
    }
}
