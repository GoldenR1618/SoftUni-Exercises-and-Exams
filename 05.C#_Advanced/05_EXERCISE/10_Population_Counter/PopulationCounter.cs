namespace _10_Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();   //<country>, <<city>, <population>>

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] inputArr = input.Split('|');
                string city = inputArr[0];
                string country = inputArr[1];
                int population = int.Parse(inputArr[2]);

                if (!dict.ContainsKey(country))
                {
                    dict[country] = new Dictionary<string, long>();
                }

                if (!dict[country].ContainsKey(city))
                {
                    dict[country].Add(city, 0);
                }

                dict[country][city] += population;

                input = Console.ReadLine();
            }

            foreach (var country in dict.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
