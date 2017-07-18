using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(' ').ToList();

            List<int> nums = new List<int>();

            for (int i = 0; i < items.Count; i++)
            {
                nums.Add(int.Parse(items[i]));
            }

            nums.Sort();
            nums.Reverse();

            for (int index = 0; index < nums.Count; index++)
            {
                if (Math.Sqrt(nums[index]) == (int)Math.Sqrt(nums[index]))
                {
                    Console.Write(nums[index] + " ");
                }
            }
        }
    }
}
