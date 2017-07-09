namespace _03.Custom_Min_Function
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomMinFunction
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Func<List<int>, int> smallestNum = n => n.Min();

            Console.WriteLine(smallestNum(nums));
        }
    }
}
