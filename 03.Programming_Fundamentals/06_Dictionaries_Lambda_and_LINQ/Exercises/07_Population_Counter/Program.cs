using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> populationCounter = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] inputArr = input.Split('|');
                string city = inputArr[0];
                string country = inputArr[1];
                int population = int.Parse(inputArr[2]);

                if (!populationCounter.ContainsKey(country))
                {
                    populationCounter[country] = new Dictionary<string, long>();
                }

                if (!populationCounter[country].ContainsKey(city))
                {
                    populationCounter[country].Add(city, 0);
                }

                populationCounter[country][city] += population;

                input = Console.ReadLine();
            }

            Dictionary<string, long> mergeDict = new Dictionary<string, long>();

            foreach (var item in populationCounter)
            {
                mergeDict[item.Key] = item.Value.Values.Sum();
            }

            foreach (var item in mergeDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");

                foreach (var index in populationCounter[item.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{index.Key}: {index.Value}");
                }
            }
        }
    }
}
