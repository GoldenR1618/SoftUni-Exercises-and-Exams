namespace _07.Bounded_Numbers
{
    using System;
    using System.Linq;

    public class BoundedNumbers
    {
        public static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int upperBound = Math.Max(bounds[0], bounds[1]);
            int lowerBound = Math.Min(bounds[0], bounds[1]);

            int[] result = sequence.Where(n => lowerBound <= n && n <= upperBound).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
