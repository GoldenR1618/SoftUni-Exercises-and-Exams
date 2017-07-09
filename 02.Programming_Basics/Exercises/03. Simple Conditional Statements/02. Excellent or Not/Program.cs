using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Excellent_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
