using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine($"{{ {string.Join(", ", arr)} }}");
            }
            else if (arr.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {string.Join(", ", ExtractMiddleEven(arr))} }}");
            }
            else
            {
                Console.WriteLine($"{{ {string.Join(", ", ExtractMiddleOdd(arr))} }}");
            }
        }

        private static int[] ExtractMiddleEven(int[] arr)
        {
            int[] extractArrEven = new int[2];
            extractArrEven[0] = arr[arr.Length / 2 - 1];
            extractArrEven[1] = arr[arr.Length / 2];

            return extractArrEven;
        }
        
        private static int[] ExtractMiddleOdd(int[] arr)
        {
            int[] extractArrOdd = new int[3];
            extractArrOdd[0] = arr[arr.Length / 2 - 1];
            extractArrOdd[1] = arr[arr.Length / 2];
            extractArrOdd[2] = arr[arr.Length / 2 + 1];

            return extractArrOdd;
        }
    }
}
