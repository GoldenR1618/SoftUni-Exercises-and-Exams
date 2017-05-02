using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            nums.Sort();
            nums.Reverse();

            var result = nums.Take(3);

            Console.WriteLine(string.Join(" ", result));

            //Console.ReadLine().Split(' ').Select(double.Parse).OrderByDescending(x => x).Take(3).ToList().ForEach(Console.WriteLine);

        }
    }
}
