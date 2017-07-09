using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();

            double[] nums = values.Split(' ').Select(double.Parse).ToArray();

            int[] roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
                roundedNums[i] = (int)Math.Round(nums[i],
                MidpointRounding.AwayFromZero);

            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine($"{nums[i]} -> {roundedNums[i]}");
        }
    }
}
