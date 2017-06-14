namespace _02.Sum_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumNumbers
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Console.WriteLine(nums.Count);
            Console.WriteLine(nums.Sum());
        }
    }
}
