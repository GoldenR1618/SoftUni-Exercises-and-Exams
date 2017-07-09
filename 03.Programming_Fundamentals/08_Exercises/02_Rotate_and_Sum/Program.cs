using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rotate_and_Sum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rotate = int.Parse(Console.ReadLine());

            int[] rotatedArr = new int[arr.Length];
            int[] sumArr = new int[arr.Length];

            for (int i = 1; i <= rotate; i++)
            {
                for (int j = 0, k = 1; j < arr.Length; j++, k++)
                {
                    if (k == arr.Length)
                    {
                        rotatedArr[0] = arr[arr.Length-1];
                    }
                    else
                    {
                        rotatedArr[k] = arr[j];
                    }
                }

                for (int h = 0; h < arr.Length; h++)
                {
                    sumArr[h] = sumArr[h] + rotatedArr[h];
                }

                for (int f = 0; f < arr.Length; f++)
                {
                    arr[f] = rotatedArr[f];
                }
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
