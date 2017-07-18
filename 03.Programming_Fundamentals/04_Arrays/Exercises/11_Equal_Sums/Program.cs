using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rightSum = 0;
            int leftSum = 0;
            bool noValidIndex = true;

            for (int index = 0; index < numbers.Length; index++)
            {
                for (int right = index; right < numbers.Length; right++)
                {
                    rightSum += numbers[right];
                }

                for (int left = index; left >= 0; left--)
                {
                    leftSum += numbers[left];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine($"{index}");
                    noValidIndex = false;
                    break;
                }
                else
                {
                    rightSum = 0;
                    leftSum = 0;
                }
            }

            if (noValidIndex)
            {
                Console.WriteLine("no");
            }
        }
    }
}
