namespace _5.HotPotato
{
    using System;
    using System.Collections.Generic;

    public class HotPotato
    {
        public static void Main(string[] args)
        {
            var children = Console.ReadLine().Split(' ');

            var number = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(children);

            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
