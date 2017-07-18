using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(num, 16));
        }
    }
}
