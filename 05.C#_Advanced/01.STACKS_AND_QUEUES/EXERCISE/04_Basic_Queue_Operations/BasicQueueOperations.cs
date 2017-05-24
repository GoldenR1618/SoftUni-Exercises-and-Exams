namespace _04_Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicQueueOperations
    {
        public static void Main(string[] args)
        {
            List<int> nsx = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int n = nsx[0];
            int s = nsx[1];
            int x = nsx[2];

            int[] nums = new int[n];
            nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            foreach (var item in nums)
            {
                numbers.Enqueue(item);
            }

            for (int i = 1; i <= s; i++)
            {
                numbers.Dequeue();
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
