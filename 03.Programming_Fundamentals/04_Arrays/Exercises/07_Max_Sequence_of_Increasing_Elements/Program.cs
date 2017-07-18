using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int countCurrentSequence = 0;
            int startCurrentSequence = 0;

            int countMaxSequence = 0;
            int startMaxSequence = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    countCurrentSequence++;
                    startCurrentSequence = i - countCurrentSequence;

                    if (countCurrentSequence > countMaxSequence)
                    {
                        countMaxSequence = countCurrentSequence;
                        startMaxSequence = startCurrentSequence;
                    }
                }
                else
                {
                    countCurrentSequence = 0;
                }
            }

            for (int i = startMaxSequence; i <= (startMaxSequence + countMaxSequence); i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
