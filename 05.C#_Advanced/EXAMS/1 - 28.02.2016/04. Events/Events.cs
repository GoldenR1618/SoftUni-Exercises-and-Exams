namespace _04.Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Events
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

            Regex rg = new Regex(@"^\s*#([A-Za-z]+):\s*@([A-Za-z]+)\s*([0-9]{1,2}:[0-9]{1,2})\s*$");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = rg.Match(input);

                string person = match.Groups[1].ToString();
                string location = match.Groups[2].ToString();
                string time = match.Groups[3].ToString();

                if (!(match.Groups[1].Success && match.Groups[2].Success && match.Groups[3].Success))
                {
                    continue;
                }

                int[] parsedTime = time.Split(':').Select(int.Parse).ToArray();
                int hours = parsedTime[0];
                int minutes = parsedTime[1];

                if (hours < 0 || hours > 23)
                {
                    continue;
                }

                if ((minutes < 0 || minutes > 59))
                {
                    continue;
                }

                if (!dict.ContainsKey(location))
                {
                    dict[location] = new Dictionary<string, List<string>>();
                }

                if (!dict[location].ContainsKey(person))
                {
                    dict[location][person] = new List<string>();
                }

                dict[location][person].Add(time);
            }

            string[] recuestedLocations = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            var result = dict.Where(x => recuestedLocations.Contains(x.Key));

            foreach (var item in result.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}:");

                int counter = 1;

                foreach (var i in item.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"{counter}. {i.Key} -> {string.Join(", ", i.Value.OrderBy(x => x))}");
                    counter++;
                }
            }
        }
    }
}
