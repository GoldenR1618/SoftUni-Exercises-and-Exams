using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < nums.Length / 2; i++)
            {
                SwapElements(nums, i, nums.Length - 1 - i);
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        static void SwapElements(string[] arr, int i, int j)
        {
            var oldElement = arr[i];
            arr[i] = arr[j];
            arr[j] = oldElement;
        }
    }
}
