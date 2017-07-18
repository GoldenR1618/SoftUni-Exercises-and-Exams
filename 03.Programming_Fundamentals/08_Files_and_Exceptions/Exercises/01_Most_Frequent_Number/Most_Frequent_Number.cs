namespace _01_Most_Frequent_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MostFrequentNumber
    {
        public static void Main(string[] args)
        {
            string input = File.ReadAllText("input3.txt");

            List<int> nums = input.Split(' ').Select(int.Parse).ToList();

            Dictionary<int, int> count = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (!count.ContainsKey(item))
                {
                    count[item] = 0;
                }

                count[item]++;
            }

            var maxValue = count.Max(x => x.Value);

            foreach (var item in count)
            {
                if (item.Value == maxValue)
                {
                    File.AppendAllText("output3.txt", item.Key.ToString());
                    break;
                }
            }
        }
    }
}
