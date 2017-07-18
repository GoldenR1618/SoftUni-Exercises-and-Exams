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

            nums.Sort();

            int counter = 1;
            int previewNumber = nums[0];
            

            for (int i = 1; i < nums.Count; i++)
            {
                int courentNumber = nums[i];

                if (previewNumber == courentNumber)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{previewNumber} -> {counter}");
                    counter = 1;
                }

                previewNumber = courentNumber;
            }

            Console.WriteLine($"{previewNumber} -> {counter}");
        }
    }
}
