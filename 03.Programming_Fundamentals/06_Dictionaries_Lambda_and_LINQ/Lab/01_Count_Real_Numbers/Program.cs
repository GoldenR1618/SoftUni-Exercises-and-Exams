using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();    //8 2.5 2.5 8 2.5

            nums.Sort();        //Сортирам.

            Dictionary<double, int> counter = new Dictionary<double, int>();        //Речник, където double са стойностите, а int е брояча.

            for (int i = 0; i < nums.Count; i++)
            {
                if (counter.ContainsKey(nums[i]))
                {
                    counter[nums[i]]++;
                }
                else
                {
                    counter.Add(nums[i], 1);
                }
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
