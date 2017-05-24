namespace _6.MathPotato
{
    using System;
    using System.Collections.Generic;

    public class MathPotato
    {
        public static void Main(string[] args)
        {
            var children = Console.ReadLine().Split(' ');

            var number = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(children);
            int cycle = 1;

            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                if (PrimeTool.IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }

                cycle++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }

    }

    public class PrimeTool
    {
        public static bool IsPrime(int n)
        {
            bool isPrime = true;

            if (n == 0 || n == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
