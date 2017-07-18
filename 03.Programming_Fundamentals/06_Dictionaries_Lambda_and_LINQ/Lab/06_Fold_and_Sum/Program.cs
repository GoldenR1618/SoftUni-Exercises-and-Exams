using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int k = nums.Count / 4;

            var left = nums.Take(k).Reverse().ToList();
            var right = nums.Skip(3 * k).Take(k).Reverse().ToList();

            var firstLine = left.Concat(right).ToList();
            var secondLine = nums.Skip(k).Take(k * 2).ToList();

            var result = firstLine.Zip(secondLine, (x, y) => (x + y)).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
