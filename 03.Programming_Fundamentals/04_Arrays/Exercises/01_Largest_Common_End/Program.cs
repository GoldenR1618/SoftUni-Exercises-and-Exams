using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(' ').ToArray();
            string[] arrTwo = Console.ReadLine().Split(' ').ToArray();

            var maxLength = Math.Min(arrOne.Length, arrTwo.Length);
            var minLength = Math.Min(arrOne.Length, arrTwo.Length);

            var leftCounter = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (arrOne[i] == arrTwo[i])
                {
                    leftCounter++;
                }
            }

            var rightCounter = 0;

            if (arrOne.Length >= arrTwo.Length)
            {
                for (int r = arrOne.Length - 1, j = arrTwo.Length - 1; j >= 0; r--, j--)
                {
                    if (arrOne[r] == arrTwo[j])
                    {
                        rightCounter++;
                    }
                }
            }
            else
            {
                for (int r = arrTwo.Length - 1, j = arrOne.Length - 1; j >= 0; r--, j--)
                {
                    if (arrOne[j] == arrTwo[r])
                    {
                        rightCounter++;
                    }
                }
            }

            if (leftCounter == 0 && rightCounter == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(Math.Max(leftCounter, rightCounter));
            }
        }
    }
}
