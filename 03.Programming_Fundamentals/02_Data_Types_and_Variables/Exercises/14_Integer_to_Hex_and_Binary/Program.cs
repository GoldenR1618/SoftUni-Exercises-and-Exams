using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string toHexa = Convert.ToString(n, 16).ToUpper();
            string toBinary = Convert.ToString(n, 2).ToUpper();
            Console.WriteLine(toHexa);
            Console.WriteLine(toBinary);
        }
    }
}
