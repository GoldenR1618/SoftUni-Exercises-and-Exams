using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] counts = new int[nums.Max() + 1];       //Пази колко пъти съответното число се среща в листа. Max() - дава най-голямото число срещано в листа.

            foreach (var num in nums)
            {
                counts[num]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                    Console.WriteLine($"{i} -> {counts[i]}");
            }
        }
    }
}

