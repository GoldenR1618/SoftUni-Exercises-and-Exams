namespace _04.Ashes_of_Roses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class AshesOfRoses
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dictionary = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            Regex regex = new Regex(@"^Grow <([A-Z][a-z]+)> <([A-Za-z0-9]+)> (\d+)$");

            while (input != "Icarus, Ignite!")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string region = match.Groups[1].ToString();
                    string color = match.Groups[2].ToString();
                    long count = int.Parse(match.Groups[3].ToString());

                    if (!dictionary.ContainsKey(region))
                    {
                        dictionary[region] = new Dictionary<string, long>();
                    }

                    if (!dictionary[region].ContainsKey(color))
                    {
                        dictionary[region].Add(color, 0);
                    }

                    dictionary[region][color] += count;
                }

                input = Console.ReadLine();
            }

            foreach (var item in dictionary.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var i in item.Value.OrderBy(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"*--{i.Key} | {i.Value}");
                }
            }
        }
    }
}
