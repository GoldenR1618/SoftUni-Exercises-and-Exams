namespace _08.Map_Districts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MapDistricts
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long minPopuation = long.Parse(Console.ReadLine());

            Dictionary<string, List<long>> dict = new Dictionary<string, List<long>>();

            foreach (var item in input)
            {
                string[] curr = item.Split(':');
                string city = curr[0];
                long population = long.Parse(curr[1]);

                if (!dict.ContainsKey(city))
                {
                    dict[city] = new List<long>();
                }

                dict[city].Add(population);
            }

            var result = dict.Where(x => x.Value.Sum() > minPopuation);

            foreach (var city in result.OrderByDescending(x => x.Value.Sum()))
            {
                Console.WriteLine($"{city.Key}: {string.Join(" ", city.Value.OrderByDescending(x => x).Take(5))}");
            }
        }
    }
}
