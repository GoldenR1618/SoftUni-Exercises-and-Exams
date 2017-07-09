namespace _04.Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindEvensOrOdds
    {
        public static void Main(string[] args)
        {
            List<int> range = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string comm = Console.ReadLine().ToLower();

            List<int> resList = new List<int>();

            if (comm == "odd")
            {
                resList = range.ExtFilter(n => n % 2 != 0);
            }
            else if (comm == "even")
            {
                resList = range.ExtFilter(n => n % 2 == 0);
            }
            else
            {
                Console.WriteLine("Wrong command!");
            }

            Console.WriteLine(string.Join(" ", resList));
        }
    }

    public static class CollectionExtensions
    {
        public static List<int> ExtFilter(this List<int> range, Func<int, bool> filter)
        {
            List<int> result = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                if (filter(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
