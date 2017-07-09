using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool inRange = (num >= 100 && num <= 200) || num == 0;

            if (!inRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
 
