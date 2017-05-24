namespace _02_Sets_Of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SetsOfElements
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            int n = arr[0];
            int m = arr[1];

            HashSet<int> nSet = new HashSet<int>();
            HashSet<int> mSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                nSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                mSet.Add(int.Parse(Console.ReadLine()));
            }

            var result = nSet.Intersect(mSet);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
