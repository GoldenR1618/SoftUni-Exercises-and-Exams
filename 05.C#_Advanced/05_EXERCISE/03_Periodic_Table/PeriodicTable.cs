namespace _03_Periodic_Table
{
    using System;
    using System.Collections.Generic;

    public class PeriodicTable
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> chCompounds = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < input.Length; j++)
                {
                    chCompounds.Add(input[j]);
                }                
            }

            Console.WriteLine(string.Join(" ", chCompounds));
        }
    }
}
