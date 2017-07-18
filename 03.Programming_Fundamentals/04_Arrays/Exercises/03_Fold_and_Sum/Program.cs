using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sumArr = new int[arr.Length / 2];

            for (int i = 0, j = arr.Length / 4, k = arr.Length / 4 - 1; i < sumArr.Length / 2; i++, j++, k--)
            {
                if (k >= 0 && j < arr.Length / 2)
                {
                    sumArr[i] = arr[j] + arr[k];
                }
            }

            for (int m = sumArr.Length - 1, n = (arr.Length / 4 + arr.Length / 2) - 1, o = arr.Length / 4 + arr.Length / 2; m >= sumArr.Length / 2; m--, n--, o++)
            {
                sumArr[m] = arr[n] + arr[o];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
