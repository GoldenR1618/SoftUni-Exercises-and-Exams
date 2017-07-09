using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bomb_Numbers
{
    class Bomb_Numbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();   //1 4 4 2 8 9 1     9 3     5

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bomb = input[0];
            int power = input[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int leftindex = Math.Max(i - power, 0);
                    int rightindex = Math.Min(i + power, numbers.Count - 1);

                    numbers.RemoveRange(i, rightindex - i);
                    numbers.RemoveAt(i);
                    numbers.RemoveRange(leftindex, i - leftindex);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join("", numbers.Sum()));
        }
    }
}
