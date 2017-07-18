using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();
            List<int> final = new List<int>();

            int counter = 1;
            int maxCounter = 1;

            result.Add(numbers[0]);

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    result.Add(numbers[i + 1]);
                }
                else
                {
                    counter = 1;
                    result.Clear();
                    result.Add(numbers[i + 1]);
                }

                if (counter > maxCounter)
                {
                    final.Clear();
                    maxCounter = counter;
                    final.AddRange(result);
                }
            }

            if (maxCounter == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            Console.WriteLine(string.Join(" ", final));
        }
    }
}

