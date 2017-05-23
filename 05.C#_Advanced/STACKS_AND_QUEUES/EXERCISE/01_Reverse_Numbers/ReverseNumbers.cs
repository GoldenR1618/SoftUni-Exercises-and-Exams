namespace _01_Reverse_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseNumbers
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Stack<int> revNums = new Stack<int>();

            foreach (var item in nums)
            {
                revNums.Push(item);
            }

            Console.WriteLine(string.Join(" ", revNums));
        }
    }
}
