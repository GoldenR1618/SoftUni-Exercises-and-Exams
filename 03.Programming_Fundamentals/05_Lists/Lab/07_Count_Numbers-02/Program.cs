using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Count_Numbers_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            nums.Sort();

            var pos = 0;

            while (pos < nums.Count)
            {
                int num = nums[pos];
                int count = 1;

                while (pos + count < nums.Count && nums[pos + count] == num)
                {
                    count++;
                }

                pos = pos + count;

                Console.WriteLine($"{num} -> {count}");
            }
        }
    }
}
