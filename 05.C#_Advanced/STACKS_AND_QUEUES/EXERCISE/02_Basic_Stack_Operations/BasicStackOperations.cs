namespace _02_Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicStackOperations
    {
        public static void Main(string[] args)
        {
            List<int> nsx = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int n = nsx[0];
            int s = nsx[1];
            int x = nsx[2];

            int[] nums = new int[n];
            nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>();

            foreach (var item in nums)
            {
                numbers.Push(item);
            }

            for (int i = 1; i <= s; i++)
            {
                numbers.Pop();
            }

            bool isThere = numbers.Contains(x);

            if (isThere)
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
        }
    }
}
