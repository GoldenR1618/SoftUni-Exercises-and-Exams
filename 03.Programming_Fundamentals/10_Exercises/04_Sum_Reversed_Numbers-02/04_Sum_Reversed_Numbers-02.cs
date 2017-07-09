using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sum_Reversed_Numbers_02
{
    class Sum_Reversed_Numbers_02
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().Split().Select(x => int.Parse(string.Join("", x.Reverse()))).Sum());
        }
    }
}
