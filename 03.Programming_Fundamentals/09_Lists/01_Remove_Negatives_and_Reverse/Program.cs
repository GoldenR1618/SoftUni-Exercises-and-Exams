using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool noPositiveNumber = true;

            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i] >= 0)
                {
                    Console.Write($"{nums[i]} ");
                    noPositiveNumber = false;
                }
            }

            if (noPositiveNumber)
            {
                Console.Write("empty");
            }
            Console.WriteLine();
        }
    }
}
